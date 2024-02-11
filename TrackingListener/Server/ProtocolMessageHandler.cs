using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TrackingListener.Application.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingListener.Helpers;
using TrackingListener.Models;
using TrackingListener.Services;

namespace TrackingListener.Server
{
    [Service(typeof(IProtocolMessageHandler))]
    public class ProtocolMessageHandler : IProtocolMessageHandler
    {
        private readonly ILogger<ProtocolMessageHandler> _logger;
        private readonly IServiceProvider _provider;
        private readonly IPositionService _positionService;

        public ProtocolMessageHandler(
            ILogger<ProtocolMessageHandler> logger,
            IServiceProvider provider,
            IPositionService positionService)
        {
            _logger = logger;
            _provider = provider;
            _positionService = positionService;
        }

        public async Task HandleMessage(ProtocolConnectionContext connectionContext, INetworkStreamWrapper networkStream,
            byte[] bytes)
        {
            ICustomMessageHandler customMessageHandler = GetMessageHandler(connectionContext.Protocol);

            MessageInput messageInput = new()
            {
                ConnectionContext = connectionContext,
                NetworkStream = networkStream,
                DataMessage = new DataMessage(bytes, connectionContext.Protocol.SplitMessageBy)
            };

            _logger.LogTrace("{ClientProtocol}: received {ConvertHexStringArrayToHexString}", connectionContext.Protocol,
                HexUtil.ConvertHexStringArrayToHexString(messageInput.DataMessage.Hex));

            try
            {
                List<Position> locations = customMessageHandler.ParseRange(messageInput)?.ToList()!;

                if (locations != null && locations.Count != 0 && connectionContext.Device != null)
                {
                    _logger.LogInformation($"Sending... {connectionContext.Device.SerialNumber} {DateTime.Now}");
                }
            }
            catch (Exception e)
            {
                _logger.LogCritical(e, "{Type}: Error parsing {DataMessageHex} ", customMessageHandler.GetType(),
                    messageInput.DataMessage.Hex);
            }
        }

        private ICustomMessageHandler GetMessageHandler(IProtocol protocol)
        {
            Type type = typeof(ICustomMessageHandler<>).MakeGenericType(protocol.GetType());

            IServiceScope serviceScope = _provider.CreateScope();
            ICustomMessageHandler customMessageHandler =
                (ICustomMessageHandler)serviceScope.ServiceProvider.GetService(type);

            if (customMessageHandler == null)
            {
                throw new Exception($"There is no message handler implemented for {protocol}");
            }

            return customMessageHandler;
        }
    }
}