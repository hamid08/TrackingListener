using System.IO;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace TrackingListener.Server;

public class NetworkStreamWrapper : INetworkStreamWrapper
{
    private readonly NetworkStream networkStream;
    public NetworkStreamWrapper(TcpClient tcpClient)
    {
        TcpClient = tcpClient;
        networkStream = TcpClient.GetStream();
    }

    public TcpClient TcpClient { get; }
    public string RemoteEndPoint => TcpClient.Client.RemoteEndPoint?.ToString()!;

    public ValueTask DisposeAsync()
    {
        TcpClient.Dispose();
        return networkStream.DisposeAsync();
    }

    public void Close()
    {
        networkStream.Close();
    }

    public bool CanRead => networkStream.CanRead;
    public bool DataAvailable => networkStream.DataAvailable;

    public int Read(byte[] buffer, int offset, int size)
    {
        try
        {
            return networkStream.Read(buffer, offset, size);
        }
        catch (IOException)
        {
            return 0;
        }
    }

    public void WriteByte(byte value)
    {
        networkStream.WriteByte(value);
    }

    public void Write(byte[] buffer)
    {
        networkStream.Write(buffer);
    }

}