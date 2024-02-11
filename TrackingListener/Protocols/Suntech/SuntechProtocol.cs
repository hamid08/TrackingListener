using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Suntech;

[Service(typeof(IProtocol))]
public class SuntechProtocol : BaseProtocol
{
    public override int Port => 7010;
    public override string SplitMessageBy => ";";
}