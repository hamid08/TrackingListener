using TrackingListener.Application.Common.Attributes;
using TrackingListener.Server;
using TrackingListener.Models;

namespace TrackingListener.Protocols.Jointech;

[Service(typeof(ICustomMessageHandler<JointechProtocol>))]
public class JointechMessageHandler : BaseMessageHandler<JointechProtocol>
{
    public override Position Parse(MessageInput input)
    {
        Position position = Parse(input,
            JointechV1MessageHandler.Parse,
            JointechV2MessageHandler.Parse);

        return position;
    }
}