using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.ReachFar;

[Service(typeof(ICustomMessageHandler<ReachFarProtocol>))]
public class ReachFarMessageHandler : BaseTkStarMessageHandler<ReachFarProtocol>
{
}