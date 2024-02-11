using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.Gosafe;

namespace TrackingListener.Protocols.Skypatrol;

[Service(typeof(IProtocol))]
public class SkypatrolProtocol : GosafeProtocol
{
    public override int Port => 7023;
}