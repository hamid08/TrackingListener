using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Concox;

[Service(typeof(IProtocol))]
public class ConcoxProtocol : BaseProtocol
{
    public override int Port => 7013;
    public override byte[] MessageStart => new byte[] { 0x78, 0x78 };
    public override IEnumerable<byte[]> MessageEnd => new List<byte[]> { new byte[] { 0x0D, 0x0A } };
}