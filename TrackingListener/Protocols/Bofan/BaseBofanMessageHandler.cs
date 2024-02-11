using System.Text.RegularExpressions;
using TrackingListener.Helpers;
using TrackingListener.Models;
using TrackingListener.Server;

namespace TrackingListener.Protocols.Bofan;

public class BaseBofanMessageHandler<T> : BaseMessageHandler<T>
{
    public override Position Parse(MessageInput input)
    {
        GPRMC gprmc = GPRMC.Parse(input.DataMessage.String);

        if (gprmc != null)
        {
            Match deviceIdMatch = new Regex(",(\\d+),(\\d{6}.\\d{3}),").Match(input.DataMessage.String);

            if (deviceIdMatch.Success)
            {
                input.ConnectionContext.SetDevice(deviceIdMatch.Groups[1].Value);

                Position position = new(gprmc)
                {
                    Device = input.ConnectionContext.Device
                };

                return position;
            }
        }

        return null;
    }
}