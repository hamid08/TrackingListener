using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.iTracGPS;

[Service(typeof(ICustomMessageHandler<iTracGPSProtocol>))]
// ReSharper disable once InconsistentNaming
public class iTracMessageHandler : BaseTkStarMessageHandler<iTracGPSProtocol>
{
}