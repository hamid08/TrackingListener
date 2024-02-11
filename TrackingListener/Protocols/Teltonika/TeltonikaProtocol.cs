using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Teltonika;

[Service(typeof(IProtocol))]
public class TeltonikaProtocol : BaseProtocol
{
    public override int Port => 7002;
}