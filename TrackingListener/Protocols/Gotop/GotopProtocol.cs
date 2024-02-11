using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Gotop;

[Service(typeof(IProtocol))]
public class GotopProtocol : BaseProtocol
{
    public override int Port => 7037;
    public override IEnumerable<byte[]> MessageEnd => new[] { new byte[] { 0x23 } };
}