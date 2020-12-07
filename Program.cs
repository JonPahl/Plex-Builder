using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlexBuilder.Extension;
using Serilog;
using System;
using System.Threading.Tasks;

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
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });


        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .UseSerilog()
        //        .ConfigureServices((_, services) =>
        //        {
        //            services.AddConfig(configuration);
        //            services.AddHostedService<PlexService>();

        //            //services.AddDbContext<PlexContext>(option =>
        //            //    option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        //            //services.AddScoped<PlexBase<TvShow>, TvShowService>();
        //            //services.AddScoped<PlexBase<Movies>, MoviesService>();
        //            //services.AddConfig<AppSettings>(configuration.GetSection("Appsettings"));
        //            //services.AddHostedService<PlexService>();

        //            //services.AddScoped<ICommand, MovieCommand>();
        //            //services.AddScoped<ICommand, TvShowCommand>();
        //        })
        //    .ConfigureAppConfiguration((IApplicationBuilder app, IWebHostEnvironment env) =>
        //    {
        //        app.ConfigureExceptionHandler();
        //    });
    }
}
