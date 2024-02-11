using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.Bofan;

namespace TrackingListener.Protocols.BlueIdea;

[Service(typeof(IProtocol))]
public class BlueIdeaProtocol : BofanProtocol
{
    public override int Port => 7044;
}