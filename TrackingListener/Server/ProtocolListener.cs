using Microsoft.Extensions.Logging;
using TrackingListener.Application.Common.Attributes;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using TrackingListener.Models;

namespace TrackingListener.Server;

[Service(typeof(IProtocolListener))]
public class ProtocolListener : IProtocolListener
{
    private readonly ILogger<ProtocolListener> _logger;
    private readonly IProtocolConnectionHandler _protocolConnectionHandler;

    public ProtocolListener(ILogger<ProtocolListener> logger,
        IProtocolConnectionHandler protocolConnectionHandler)
    {
        _logger = logger;
        _protocolConnectionHandler = protocolConnectionHandler;
    }

    public async Task Start(IProtocol protocol, CancellationToken cancellationToken)
    {
        TcpListener listener = null;

        try
        {
            listener = new TcpListener(IPAddress.Any, protocol.Port);
            listener.Start();
            _logger.LogDebug("{Protocol}: listening on {ProtocolPort}", protocol, protocol.Port);

            // Enable keepalive
            listener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    TcpClient tcpClient = await listener.AcceptTcpClientAsync(cancellationToken);
                    ProtocolConnectionContext connectionContext = await GetConnectionContext(protocol, tcpClient);

                    _ = _protocolConnectionHandler.HandleConnection(connectionContext, cancellationToken);
                }
                catch (SocketException socketException) when (socketException.SocketErrorCode == SocketError.ConnectionReset)
                {
                    _logger.LogWarning(socketException, "{Protocol}: An existing connection was forcibly closed by the remote host.", protocol);
                }
                catch (Exception exception)
                {
                    _logger.LogCritical(exception, "{Protocol}", protocol);
                }
            }
        }
        finally
        {
            listener?.Stop();
        }
    }

    private async Task<ProtocolConnectionContext> GetConnectionContext(IProtocol protocol, TcpClient tcpClient)
    {
        NetworkStreamWrapper networkStream = new(tcpClient);

        ProtocolConnectionContext connectionContext =
            new(networkStream, protocol);

        return connectionContext;
    }
}