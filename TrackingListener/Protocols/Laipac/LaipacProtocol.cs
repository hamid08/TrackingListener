using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Laipac;

[Service(typeof(IProtocol))]
public class LaipacProtocol : BaseProtocol
{
    public override int Port => 7052;
}