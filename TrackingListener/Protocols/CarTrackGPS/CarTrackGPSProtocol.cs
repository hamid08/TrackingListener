using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.CarTrackGPS;

[Service(typeof(IProtocol))]
public class CarTrackGPSProtocol : BaseProtocol
{
    public override int Port => 7033;
    public override byte[] MessageStart => new byte[] { 0x24, 0x24 };
}