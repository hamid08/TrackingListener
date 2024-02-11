using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Jointech;

[Service(typeof(IProtocol))]
public class JointechProtocol : BaseProtocol
{
    public override int Port => 7040;
}