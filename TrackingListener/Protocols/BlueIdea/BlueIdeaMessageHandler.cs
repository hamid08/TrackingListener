using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.Bofan;

namespace TrackingListener.Protocols.BlueIdea;

[Service(typeof(ICustomMessageHandler<BlueIdeaProtocol>))]
public class BlueIdeaMessageHandler : BaseBofanMessageHandler<BlueIdeaProtocol>
{
}