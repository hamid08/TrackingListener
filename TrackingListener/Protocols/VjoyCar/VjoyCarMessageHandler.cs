using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.VjoyCar;

[Service(typeof(ICustomMessageHandler<VjoyCarProtocol>))]
public class VjoyCarMessageHandler : BaseVjoyCarMessageHandler<VjoyCarProtocol>
{
}