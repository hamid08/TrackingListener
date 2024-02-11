using System.Collections.Generic;
using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.Carscop;

[Service(typeof(IProtocol))]
public class CarscopProtocol : TkStarProtocol
{
    public override int Port => 7016;
    public override IEnumerable<byte[]> MessageEnd => new List<byte[]> { new byte[] { 0x23 }, new byte[] { 0x5E } };
}