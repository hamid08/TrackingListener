using System;

namespace TrackingListener.Models;

public class Device
{
    public Device(string serialNumber)
    {
        SerialNumber = serialNumber;
    }

    public string SerialNumber { get; init; }
    public DateTime? MaxDate { get; set; }
}