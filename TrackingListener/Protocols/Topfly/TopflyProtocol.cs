using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Topfly;

[Service(typeof(IProtocol))]
public class TopflyProtocol : BaseProtocol
{
    public override int Port => 7050;
    public override byte[] MessageStart => new byte[] { 0x23, 0x23 };
}