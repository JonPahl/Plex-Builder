using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using PlexBuilder;
using Serilog;
using PlexBuilder.SqlModels;
using PlexBuilder.Service;

namespace Service
{
    public static class Program
    {
        private static IConfiguration configuration;

        static async Task Main(string[] args)
        {
            configuration = new ConfigurationBuilder().AddJsonFile(@"appsettings.json").Build();
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

            try
            {
                Log.Information("Starting host");

                var builder = CreateHostBuilder(args).Build();
                builder.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex.Message, ex);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<PlexContext>(option =>
                    {
                        option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                    });

                    services.AddScoped<PlexBase, TvShowService>();
                    services.AddScoped<PlexBase, MoviesService>();
                    services.AddHostedService<PlexService>();
                });
    }
}
