using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Xexun;

[Service(typeof(IProtocol))]
public class XexunProtocol : BaseProtocol
{
    public override int Port => 7017;
}