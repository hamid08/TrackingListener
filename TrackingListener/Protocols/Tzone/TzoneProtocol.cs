using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Tzone;

[Service(typeof(IProtocol))]
public class TzoneProtocol : BaseProtocol
{
    public override int Port => 7006;
    public override byte[] MessageStart => new byte[] { 0x24, 0x24 };
    public override IEnumerable<byte[]> MessageEnd => new List<byte[]> { new byte[] { 0x0D, 0x0A } };
}