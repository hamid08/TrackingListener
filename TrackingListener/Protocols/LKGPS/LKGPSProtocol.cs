using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.LKGPS;

[Service(typeof(IProtocol))]
public class LKGPSProtocol : TkStarProtocol
{
    public override int Port => 7015;
}