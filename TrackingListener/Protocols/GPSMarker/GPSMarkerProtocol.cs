using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.GPSMarker;

[Service(typeof(IProtocol))]
public class GPSMarkerProtocol : BaseProtocol
{
    public override int Port => 7047;
    public override byte[] MessageStart => new byte[] { 0x24 };
    public override IEnumerable<byte[]> MessageEnd => new[] { new byte[] { 0x23 } };
}