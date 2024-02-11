using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.iCarGPS;

[Service(typeof(ICustomMessageHandler<iCarGPSProtocol>))]
// ReSharper disable once InconsistentNaming
public class iCarGPSMessageHandler : BaseTkStarMessageHandler<iCarGPSProtocol>
{
}