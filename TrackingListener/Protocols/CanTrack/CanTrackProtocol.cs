using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.CanTrack;

[Service(typeof(IProtocol))]
public class CanTrackProtocol : TkStarProtocol
{
    public override int Port => 7014;
}