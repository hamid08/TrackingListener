using TrackingListener.Server;

namespace TrackingListener.Models
{
    public class ProtocolConnectionContext : IAsyncDisposable
    {
        public ProtocolConnectionContext(INetworkStreamWrapper networkStream, IProtocol protocol)
        {
            Protocol = protocol;
            NetworkStream = networkStream;
        }

        public IProtocol Protocol { get; }
        public Device? Device { get; private set; }
        public INetworkStreamWrapper NetworkStream { get; }
        public DateTime? MaxDate { get; set; }

        public void SetDevice(string serialNumber)
        {
            if (!string.IsNullOrEmpty(serialNumber) && Device == null)
            {
                Device = new Device(serialNumber);
            }
        }

        public T? GetClientCache<T>(string key)
        {
            return ClientCache.TryGetValue(key, out object? value) && value != null ? (T)value : default;
        }

        public void SetClientCache<T>(string key, T? value)
        {
            ClientCache[key] = value;
        }

        private Dictionary<string, object?> ClientCache { get; } = new();

        public async ValueTask DisposeAsync()
        {
            await NetworkStream.DisposeAsync();
        }
    }
}