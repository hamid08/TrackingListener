using System.Collections.Generic;
using TrackingListener.Models;

namespace TrackingListener.Server;

public interface ICustomMessageHandler
{
    Position Parse(MessageInput input);
    IEnumerable<Position> ParseRange(MessageInput input);
}

public interface ICustomMessageHandler<T> : ICustomMessageHandler
{
}