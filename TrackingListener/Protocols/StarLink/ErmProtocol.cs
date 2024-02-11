using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.StarLink;

[Service(typeof(IProtocol))]
public class ErmProtocol : BaseProtocol
{
    public override int Port => 7051;
}