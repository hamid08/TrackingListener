using System.Threading;
using System.Threading.Tasks;
using TrackingListener.Models;

namespace TrackingListener.Server;

public interface IProtocolConnectionHandler
{
    Task HandleConnection(ProtocolConnectionContext connectionContext, CancellationToken cancellationToken);
}