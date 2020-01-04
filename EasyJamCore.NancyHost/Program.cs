namespace EasyJamCore.NancyHost
{
    using System.IO;
    using Microsoft.AspNetCore.Hosting;

    public static class Program
    {
        public static void Main()
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
