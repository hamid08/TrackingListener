using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.VjoyCar;

namespace TrackingListener.Protocols.Smartrack;

[Service(typeof(ICustomMessageHandler<SmartrackProtocol>))]
public class SmartrackMessageHandler : BaseVjoyCarMessageHandler<SmartrackProtocol>
{
}