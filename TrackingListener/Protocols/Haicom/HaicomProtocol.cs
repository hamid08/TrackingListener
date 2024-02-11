using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Haicom;

[Service(typeof(IProtocol))]
public class HaicomProtocol : BaseProtocol
{
    public override int Port => 7032;
    public override byte[] MessageStart => new byte[] { 0x24 };
}