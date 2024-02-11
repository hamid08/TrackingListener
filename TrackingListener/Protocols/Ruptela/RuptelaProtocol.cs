using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Ruptela;

[Service(typeof(IProtocol))]
public class RuptelaProtocol : BaseProtocol
{
    public override int Port => 7056;
}