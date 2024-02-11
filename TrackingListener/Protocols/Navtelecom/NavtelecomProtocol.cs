using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Navtelecom;

[Service(typeof(IProtocol))]
public class NavtelecomProtocol : BaseProtocol
{
    public override int Port => 7054;
}