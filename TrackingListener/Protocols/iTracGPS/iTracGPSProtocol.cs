using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.iTracGPS;

[Service(typeof(IProtocol))]
// ReSharper disable once InconsistentNaming
public class iTracGPSProtocol : TkStarProtocol
{
    public override int Port => 7028;
}