using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.SinoTrack;

[Service(typeof(IProtocol))]
public class SinoTrackProtocol : TkStarProtocol
{
    public override int Port => 7012;
}