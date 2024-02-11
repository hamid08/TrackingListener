using System.Threading.Tasks;
using TrackingListener.Models;

namespace TrackingListener.Server;

public interface IProtocolMessageHandler
{
    Task HandleMessage(ProtocolConnectionContext connectionContext, INetworkStreamWrapper networkStream, byte[] bytes);
}