using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Amwell;

[Service(typeof(IProtocol))]
public class AmwellProtocol : BaseProtocol
{
    public override int Port => 7035;
    public override byte[] MessageStart => new byte[] { 0x29, 0x29 };
    public override IEnumerable<byte[]> MessageEnd => new List<byte[]> { new byte[] { 0x0D } };
}