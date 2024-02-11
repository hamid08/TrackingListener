using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Bofan;

[Service(typeof(ICustomMessageHandler<BofanProtocol>))]
public class BofanMessageHandler : BaseBofanMessageHandler<BofanProtocol>
{
}