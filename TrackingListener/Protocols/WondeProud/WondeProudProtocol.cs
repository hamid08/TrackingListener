using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.WondeProud;

[Service(typeof(IProtocol))]
public class WondeProudProtocol : BaseProtocol
{
    public override int Port => 7046;
}