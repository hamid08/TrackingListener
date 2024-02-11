using System;

namespace TrackingListener.Services;

public class SavePositionsResult
{
    public DateTime MaxDate { get; set; }
    public bool Success { get; set; }
}