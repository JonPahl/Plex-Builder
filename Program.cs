using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using PlexBuilder.SqlModels;
using PlexBuilder.Service;
using PlexBuilder.Extension;
using PlexBuilder.Models;
using PlexBuilder.Abstract;
using PlexBuilder.Commands;

namespace PlexBuilder
{
    public static class Program
    {
        private static IConfiguration configuration;

        public static async Task Main(string[] args)
        {
            //var currentDirectoryPath = Directory.GetCurrentDirectory();
            //var envSettingsPath = Path.Combine(currentDirectoryPath, "envsettings.json");
            //var envSettings = JObject.Parse(File.ReadAllText(envSettingsPath));
            //var enviromentValue = envSettings["ASPNETCORE_ENVIRONMENT"].ToString();

            //IHostEnvironment env = HostEnvironmentEnvExtensions.
            // Environment.Devleopment;

            //IWebHostEnvironment.EnvironmentName

            var devSettings = $"appsettings.{Environments.Development}.json";

            configuration = new ConfigurationBuilder()
               //.SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json")
               .AddJsonFile(devSettings, true, false)
               .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom
                .Configuration(configuration)
                .CreateLogger();

            try
            {
                Log.Information("Starting host");

                var builder = CreateHostBuilder(args).Build();
                await builder.RunAsync().ConfigureAwait(false);
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
                .ConfigureServices((_, services) =>
                {
                    services.AddDbContext<PlexContext>(option =>
                        option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
                    services.AddScoped<PlexBase<TvShow>, TvShowService>();
                    services.AddScoped<PlexBase<Movies>, MoviesService>();
                    services.AddConfig<AppSettings>(configuration.GetSection("Appsettings"));
                    services.AddHostedService<PlexService>();

                    services.AddScoped<ICommand, MovieCommand>();
                    services.AddScoped<ICommand, TvShowCommand>();
                });
    }
}
