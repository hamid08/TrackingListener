using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.TkStar;

namespace TrackingListener.Protocols.XeElectech;

[Service(typeof(IProtocol))]
public class XeElectechProtocol : TkStarProtocol
{
    public override int Port => 7019;
}