using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.GoPass;

[Service(typeof(IProtocol))]
public class GoPassProtocol : BaseProtocol
{
    public override int Port => 7039;
}