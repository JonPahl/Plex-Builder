using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlexBuilder.Abstract;
using PlexBuilder.Commands;
using PlexBuilder.Extension;
using PlexBuilder.Models;
using PlexBuilder.Service;
using PlexBuilder.SqlModels;

namespace PlexBuilder
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PlexContext>(option =>
                        option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<PlexBase<TvShow>, TvShowService>();
            services.AddScoped<PlexBase<Movies>, MoviesService>();
            services.AddConfig<AppSettings>(configuration.GetSection("Appsettings"));
            services.AddScoped<ICommand, AllLibrariesCommand>();
            services.AddScoped<ICommand, MovieCommand>();
            services.AddScoped<ICommand, TvShowCommand>();

            //services.Configure<PositionOptions>(config.GetSection(PositionOptions.Position));
            //services.Configure<ColorOptions>(config.GetSection(ColorOptions.Color));
            return services;
        }
    }
}
