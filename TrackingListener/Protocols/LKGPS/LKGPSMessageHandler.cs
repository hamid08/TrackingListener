using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.LKGPS;

[Service(typeof(ICustomMessageHandler<LKGPSProtocol>))]
public class LKGPSMessageHandler : BaseTkStarMessageHandler<LKGPSProtocol>
{
}