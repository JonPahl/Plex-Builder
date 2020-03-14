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
using System.Configuration;

namespace Service
{
    public static class Program
    {
        private static IConfiguration configuration;


        static async Task Main(string[] args)
        {
            //var currentDirectoryPath = Directory.GetCurrentDirectory();
            //var envSettingsPath = Path.Combine(currentDirectoryPath, "envsettings.json");
            //var envSettings = JObject.Parse(File.ReadAllText(envSettingsPath));
            //var enviromentValue = envSettings["ASPNETCORE_ENVIRONMENT"].ToString();

            //IHostEnvironment env = HostEnvironmentEnvExtensions.
            // Environment.Devleopment;

            var devSettings = $"appsettings.{EnvironmentName.Development}.json";
            //Console.WriteLine();

            configuration = new ConfigurationBuilder()
                
               //.SetBasePath(env.ContentRootPath)
               .AddJsonFile(@"appsettings.json")
               .AddJsonFile(devSettings, true, false)
               //.AddJsonFile(@"appsettings.development.json", false, false)
               .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom
                .Configuration(configuration)
                .CreateLogger();

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

                    //services.AddScoped<Configuration, IConfiguration>();

                    services.AddScoped<PlexBase<TvShow>, TvShowService>();
                    services.AddScoped<PlexBase<Movies>, MoviesService>();
                    services.AddHostedService<PlexService>();
                });
    }
}
