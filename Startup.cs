using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplicationMotor
{
    public class Startup
    {
        // Este método se utiliza para agregar servicios al contenedor de inyección de dependencias.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // Agrega soporte para controladores y vistas MVC
        }

        // Este método se utiliza para configurar la canalización de solicitudes HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Página de error detallada en entorno de desarrollo
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // Página de error genérica en otros entornos
                app.UseHsts(); // Middleware de HSTS (Strict Transport Security)
            }

            app.UseHttpsRedirection(); // Redirige solicitudes HTTP a HTTPS
            app.UseStaticFiles(); // Sirve archivos estáticos (CSS, imágenes, etc.)
            app.UseRouting(); // Configura el enrutamiento
            app.UseAuthorization(); // Configura la autorización (si es necesario)

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); // Ruta predeterminada
            });
        }
    }
}