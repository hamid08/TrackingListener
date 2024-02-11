using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.CanTrack;

[Service(typeof(ICustomMessageHandler<CanTrackProtocol>))]
public class CanTrackMessageHandler : BaseTkStarMessageHandler<CanTrackProtocol>
{
}