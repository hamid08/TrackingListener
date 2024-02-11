using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Queclink;

[Service(typeof(IProtocol))]
public class QueclinkProtocol : BaseProtocol
{
    public override int Port => 7008;
    public override IEnumerable<byte[]> MessageEnd => new List<byte[]> { new byte[] { 0x24 } };
}