using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.TkStar;

[Service(typeof(ICustomMessageHandler<TkStarProtocol>))]
public class TkStarMessageHandler : BaseTkStarMessageHandler<TkStarProtocol>
{
}