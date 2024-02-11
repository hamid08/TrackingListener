using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.ReachFar;

[Service(typeof(IProtocol))]
public class ReachFarProtocol : TkStarProtocol
{
    public override int Port => 7026;
}