using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Freedom;

[Service(typeof(IProtocol))]
public class FreedomProtocol : BaseProtocol
{
    public override int Port => 7049;
}