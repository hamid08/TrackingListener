using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrackingListener.Models;

namespace TrackingListener.Services;

public interface IPositionService
{
    Task<SavePositionsResult> Save(Device device, DateTime maxEndDate,
        IEnumerable<Position> locations);
}