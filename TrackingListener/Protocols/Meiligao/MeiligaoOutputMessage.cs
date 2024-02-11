using TrackingListener.Helpers;
using static System.String;

namespace TrackingListener.Protocols.Meiligao;

public class MeiligaoOutputMessage
{
    private const string PacketHeaderHex = "4040";
    private const string PacketEndHex = "0D0A";

    public MeiligaoCommands Command { get; }
    public string[] DeviceId { get; }
    public string Data { get; }

    public string PacketBody => $"{PacketHeaderHex}{PacketLength:X4}{Join(Empty, DeviceId)}{(int)Command:X2}{Data}";

    public string PacketBodyWithChecksum => $"{PacketBody}{Checksum}{PacketEndHex}";

    public int PacketLength => 2 + 2 + 7 + 2 + Data.Length / 2 + 2 + 2;

    public string Checksum => $"{Crc16Util.Ccitt(HexUtil.ConvertHexStringToByteArray(PacketBody)):X4}";

    public MeiligaoOutputMessage(MeiligaoCommands command, string[] deviceId, string data)
    {
        Command = command;
        DeviceId = deviceId;
        Data = data;
    }
}