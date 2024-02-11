using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.KeSon;

[Service(typeof(IProtocol))]
public class KeSonProtocol : BaseProtocol
{
    public override int Port => 7041;
}