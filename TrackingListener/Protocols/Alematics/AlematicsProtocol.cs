using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Alematics;

[Service(typeof(IProtocol))]
public class AlematicsProtocol : BaseProtocol
{
    public override int Port => 7029;
    public override byte[] MessageStart => new byte[] { 0x24 };
}