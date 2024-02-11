using Microsoft.Extensions.Hosting;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using TrackingListener.Application.Common.Extensions;


namespace TrackingListener;

public class Program
{
    public static async Task Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        HostApplicationBuilder hostApplicationBuilder = Host.CreateApplicationBuilder();

        hostApplicationBuilder.Services.AddCustomServices<Program>();

        IHost host = hostApplicationBuilder.Build();

        await host.RunAsync();
    }
}