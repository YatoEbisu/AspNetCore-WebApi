using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Store.Domain.Interfaces;
using Store.Infra.Data.Context;
using Store.Infra.Data.Repository;
using Store.Service.Services;
using System;

namespace Store.Application.Config
{
    public static class APIConfig
    {
        public static IServiceCollection AddAPIConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.AddDbContext<StoreContext>(opt => opt
             .UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();


            //services.AddSwaggerGen();
            return services;
        }

        public static IApplicationBuilder UseAPIConfig(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Store V1");
            //    c.RoutePrefix = string.Empty;
            //});

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }

    }
}
