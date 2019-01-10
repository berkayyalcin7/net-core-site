using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace netcore.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //Hata Sayfası gösterme
                app.UseDeveloperExceptionPage();
            }
            
            //Bi istek atıldığında dönen değer
            /*  Hello world
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            }); */

           // TODO : Css Js Dosyaları için 
          
           app.UseStaticFiles();
           //UseMVC ' yi yukarı yazarsak iconlar veya Js dosyaları hata verebiliyor.
           //Daha sonra MVC ' yi kullan diyoruz : Not -> Bunların sırası önemli ilk StaticFiles kullan dedik
           app.UseMvc();

           //dotnet build ve dotnet 'run' ile çalıştırıyoruz


        }
    }
}
