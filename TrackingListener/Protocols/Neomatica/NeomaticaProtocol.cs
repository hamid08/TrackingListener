using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Neomatica;

[Service(typeof(IProtocol))]
public class NeomaticaProtocol : BaseProtocol
{
    public override int Port => 7058;
}