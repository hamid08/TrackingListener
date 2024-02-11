using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.ManPower;

[Service(typeof(IProtocol))]
public class ManPowerProtocol : BaseProtocol
{
    public override int Port => 7045;
}