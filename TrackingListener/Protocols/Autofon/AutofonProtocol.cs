using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Autofon;

[Service(typeof(IProtocol))]
public class AutofonProtocol : BaseProtocol
{
    public override int Port => 7060;
}