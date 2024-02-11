using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.SinoTrack;

[Service(typeof(ICustomMessageHandler<SinoTrackProtocol>))]
public class SinoTrackMessageHandler : BaseTkStarMessageHandler<SinoTrackProtocol>
{
}