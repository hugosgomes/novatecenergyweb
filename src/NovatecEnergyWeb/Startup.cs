using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NovatecEnergyWeb.Models;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.Exportacao;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Repository;
using NovatecEnergyWeb.Domain.Interfaces;
using NovatecEnergyWeb.Domain.Services;

namespace NovatecEnergyWeb
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }
            Configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<BDNVTContext>();

            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("Production"));

            AppSettings.contexto = new BDNVTContext(optionsBuilder.Options);

            AppSettings.ExcelExportUrl = Configuration.GetValue<string>("ExcelExportUrl:Dev");

        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<BDNVTContext>(options =>

            options.UseSqlServer(Configuration.GetConnectionString("Production")));


            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            services.AddScoped<IPcoRepository, PcoRepository>();
            services.AddScoped<IAreaRepository, AreaRepository>();
            services.AddScoped<ILoteRepository, LoteRepository>();
            services.AddScoped<ICondominioLoteAtivo, CondominioLoteAtivoRepository>();
            services.AddScoped<IMotivoRejeicao, MotivoRejeicaoRepository>();
            services.AddScoped<IExcelExporterLotePorClienteApartamento, ExcelExporterLotePorClienteApartamento>();
            services.AddScoped<ILoteEstatisticaRepository, LoteEstatisticaRepository>();
            services.AddScoped<IDelegacaoRepository, DelegacaoRepository>();
            services.AddScoped<IVisitasRepository, VisitasRepository>();
            services.AddScoped<IExcelExportVisitasApartamento, ExcelExportVisitasApartamento>();
            services.AddScoped<ICondEstatisticaRepository, CondEstatisticaRepository>();
            services.AddScoped<ICondVisitasRepository, CondVisitasRepository>();
            services.AddScoped<IVisitaEnderecoRepository, VisitaEnderecoRepository>();
            services.AddScoped<IExcelExportVisitaEnderecoCondominio, ExcelExportVisitaEnderecoCondominio>();
            services.AddScoped<ILotePcoRepository, LotePcoRepository>();
            services.AddScoped<IVisitaPcoRepository, VisitaPcoRepository>();
            services.AddScoped<ILoteEstatisticaPcoRepository, LoteEstatisticaPcoRepository>();
            services.AddScoped<IVisitaEnderecoPcoRepository, VisitaEnderecoPcoRepository>();
            services.AddScoped<ILoteCondominioRepository, LoteCondominioRepository>();

            services.AddMvc();



            services.AddMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.CookieName = ".MyApplication";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseSession();

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseApplicationInsightsExceptionTelemetry();

            app.UseStaticFiles();



            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
