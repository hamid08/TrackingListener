using TrackingListener.Helpers;
using TrackingListener.Helpers.Crc;
using static System.String;

namespace TrackingListener.Protocols.Concox;

public class ConcoxOutputMessage
{
    private const string PacketHeaderHex = "7878";
    private const string PacketEndHex = "0D0A";

    public ProtocolNumber Number { get; }
    public string[] SerialNumber { get; }

    public string PacketBody => $"{PacketLength:X2}{(int)Number:X2}{Join(Empty, SerialNumber)}";

    public string PacketFull => $"{PacketHeaderHex}{PacketBody}{Checksum}{PacketEndHex}";

    // 1 (protocol number) + 2 (serial number) + 2 (checksum)
    public static int PacketLength => 1 + 2 + 2;

    public ConcoxOutputMessage(ProtocolNumber number, string[] serialNumber)
    {
        Number = number;
        SerialNumber = serialNumber;
    }

    public string Checksum =>
        Crc.ComputeHash(HexUtil.ConvertHexStringToByteArray(PacketBody), CrcAlgorithm.Crc16X25);
}