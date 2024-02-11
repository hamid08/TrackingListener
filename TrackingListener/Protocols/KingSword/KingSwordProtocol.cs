using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.KingSword;

[Service(typeof(IProtocol))]
public class KingSwordProtocol : BaseProtocol
{
    public override int Port => 7034;
    public override byte[] MessageStart => new byte[] { 0x2A };
    public override IEnumerable<byte[]> MessageEnd => new[] { new byte[] { 0x23 } };
}