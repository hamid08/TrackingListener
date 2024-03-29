using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.GlobalSat;

[Service(typeof(IProtocol))]
public class GlobalSatProtocol : BaseProtocol
{
    public override int Port => 7038;
    public override IEnumerable<byte[]> MessageEnd => new[] { new byte[] { 0x21 } };
}