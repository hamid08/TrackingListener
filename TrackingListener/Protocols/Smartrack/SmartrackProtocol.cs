using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.VjoyCar;

namespace TrackingListener.Protocols.Smartrack;

[Service(typeof(IProtocol))]
public class SmartrackProtocol : VjoyCarProtocol
{
    public override int Port => 7025;
}