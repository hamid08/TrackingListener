using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Gosafe;

[Service(typeof(ICustomMessageHandler<GosafeProtocol>))]
public class GosafeMessageHandler : BaseGosafeMessageHandler<GosafeProtocol>
{
}