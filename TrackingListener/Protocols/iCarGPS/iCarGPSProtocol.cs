using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.iCarGPS;

[Service(typeof(IProtocol))]
// ReSharper disable once InconsistentNaming
public class iCarGPSProtocol : TkStarProtocol
{
    public override int Port => 7027;
}