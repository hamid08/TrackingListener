using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Galileosky;

[Service(typeof(IProtocol))]
public class GalileoskyProtocol : BaseProtocol
{
    public override int Port => 7055;
}