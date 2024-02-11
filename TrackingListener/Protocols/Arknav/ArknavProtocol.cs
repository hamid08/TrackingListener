using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Arknav;

[Service(typeof(IProtocol))]
public class ArknavProtocol : BaseProtocol
{
    public override int Port => 7031;
}