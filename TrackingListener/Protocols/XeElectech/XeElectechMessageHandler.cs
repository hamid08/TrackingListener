using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.XeElectech;

[Service(typeof(ICustomMessageHandler<XeElectechProtocol>))]
public class XeElectechMessageHandler : BaseTkStarMessageHandler<XeElectechProtocol>
{
}