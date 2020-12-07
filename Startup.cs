using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlexBuilder.Extension;

namespace PlexBuilder
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddConfig(Configuration);
            services.AddHostedService<PlexService>();

            //string[] args = Array.Empty<string>();
            //var startup = PlexBuilder.Program.CreateHostBuilder(args);

            //services.AddConfig(Configuration);

            //services.AddControllers();
            //services.AddSwaggerGen(c =>
            //c.SwaggerDoc("v1", new OpenApiInfo { Title = "PlexBuilder.Api", Version = "v1" }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.ConfigureExceptionHandler();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseSwagger();
            //    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PlexBuilder.Api v1"));
            //}

            //app.UseRouting();
            //app.UseAuthorization();
            //app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
