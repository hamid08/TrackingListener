using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Xirgo;

[Service(typeof(IProtocol))]
public class XirgoProtocol : BaseProtocol
{
    public override int Port => 7024;
    public override byte[] MessageStart => new byte[] { 0x24, 0x24 };
    public override IEnumerable<byte[]> MessageEnd => new List<byte[]> { new byte[] { 0x23, 0x23 } };
}