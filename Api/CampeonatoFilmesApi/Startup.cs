using CampeonatoFilmesApi.Data.Repository;
using CampeonatoFilmesApi.Data.Repository.Implementations;
using CampeonatoFilmesApi.Service;
using CampeonatoFilmesApi.Service.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;
using System.Reflection;

namespace CampeonatoFilmesApi
{
    public class Startup
    {
        /// <summary>
        /// Nome da regra de cross origin.
        /// </summary>
        readonly string developmentRulesName = "liberatudo";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //cors

            services.AddCors(options =>
            {
                options.AddPolicy(developmentRulesName,
                    builder => builder.AllowAnyOrigin().AllowAnyHeader());
            });

            //Dependency injection
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<IFilmeRepository, FilmeRepository>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "Campeonato de Filmes",
                    Version = "v1",
                    Description = "API desenvolvida para fornecer os resultados do campeonato de filmes.",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                    {
                        Name = "WAVES Systems",
                        Url = new Uri("https://www.github.com/KennedyWaves")
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath, true);

                ;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CampeonatoFilmesApi v1"));
            }
            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(developmentRulesName);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
