using System.Threading;
using System.Threading.Tasks;

namespace TrackingListener.Server;

public interface IProtocolListener
{
    Task Start(IProtocol protocol, CancellationToken cancellationToken);

}