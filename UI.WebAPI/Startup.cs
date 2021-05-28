using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.Entidades;
using Infra.AccesoDatos.OrigenDato;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Negocio.Servicio.Implementacion;
using Negocio.Servicio.Interface;

using Microsoft.OpenApi.Models;

namespace UI.WebAPI
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

            AddSwagger(services);

            var mapperConfig = new MapperConfiguration(m =>
              {
                  m.AddProfile(new MappingProfile());
              });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();
            services.AddSingleton<IClienteServicio>(option => new ClienteServicio(Configuration.GetConnectionString("DemoConnection")));
            services.AddSingleton<IProductoServicio>(option => new ProductoServicio(Configuration.GetConnectionString("DemoConnection")));
            //services.AddScoped<IClienteServicio, ClienteServicio>();
            //services.AddEntityFrameworkSqlServer();
            //services.AddDbContextPool<TestContext>(options =>
            //                options.UseSqlServer(Configuration.GetConnectionString("DemoConnection")));
            //services.AddDbContextPool<TestContext>((serviceProvider, optionsBuilder) =>
            //{
            //    optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DemoConnection"));
            //    optionsBuilder.UseInternalServiceProvider(serviceProvider);
            //});
        }

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Foo API V1");
            });
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"Foo {groupName}",
                    Version = groupName,
                    Description = "Foo API",
                    Contact = new OpenApiContact
                    {
                        Name = "Foo Company",
                        Email = string.Empty,
                        Url = new Uri("https://foo.com/"),
                    }
                });
            });
        }
    }
}
