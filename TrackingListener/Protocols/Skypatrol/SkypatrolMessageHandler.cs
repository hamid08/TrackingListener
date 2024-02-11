using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Protocols.Gosafe;

namespace TrackingListener.Protocols.Skypatrol;

[Service(typeof(ICustomMessageHandler<SkypatrolProtocol>))]
public class SkypatrolMessageHandler : BaseGosafeMessageHandler<SkypatrolProtocol>
{
}