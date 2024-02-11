using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.ATrack;

[Service(typeof(IProtocol))]
public class ATrackProtocol : BaseProtocol
{
    public override int Port => 7061;
}