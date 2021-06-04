using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaynJungle.BL.Contracts;
using KaynJungle.BL.Implementations;
using KaynJungle.DAL.Models;
using KaynJungle.DAL.Repositories.Contracts;
using KaynJungle.DAL.Repositories.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KaynJungle
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
            services.AddControllers();

            //Aquí inyección del contexto:

            services.AddDbContext<ConcesionarioDBContext>(opts => opts.UseMySql(Configuration["ConnectionString:TallerDB"], ServerVersion.AutoDetect(Configuration["ConnectionString:TallerDB"])));

            //Para habilitar CORS en nuestra API
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            //Aquí las inyecciones: Interfaz - Clase
            services.AddScoped<IUsuarioBL, UsuarioBL>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IVentaBL, VentaBL>();
            services.AddScoped<IVentaRepository, VentaRepository>();
        }
        //dotnet ef dbcontext scaffold "server=localhost;port=3306;user=root;password=1234546;database=elproyecto" MySql.Data:EntityFrameworkCore -o mismodelos
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
