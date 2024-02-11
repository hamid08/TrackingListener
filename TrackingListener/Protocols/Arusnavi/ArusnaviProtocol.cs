using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Arusnavi;

[Service(typeof(IProtocol))]
public class ArusnaviProtocol : BaseProtocol
{
    public override int Port => 7057;
}