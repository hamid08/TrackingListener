using TrackingListener.Application.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingListener.Models;

namespace TrackingListener.Services
{
    [Service(typeof(IPositionService))]
    public class PositionService : IPositionService
    {

        public async Task<SavePositionsResult> Save(Device device, DateTime maxEndDate,
            IEnumerable<Position> locations)
        {
            SavePositionsResult result = new();

            return result;
        }

    }
}