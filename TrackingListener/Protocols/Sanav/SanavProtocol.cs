using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Sanav;

[Service(typeof(IProtocol))]
public class SanavProtocol : BaseProtocol
{
    public override int Port => 7036;
}