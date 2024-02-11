using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Satellite;

[Service(typeof(IProtocol))]
public class SatelliteProtocol : BaseProtocol
{
    public override int Port => 7059;
}