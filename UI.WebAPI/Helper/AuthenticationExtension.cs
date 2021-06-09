using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.WebAPI
{
    public static class AuthenticationExtension
    {
        public static IServiceCollection AddTokenAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var siginKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["Auth:Jwt:Key"]));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuerSigningKey = true,
                    RequireExpirationTime = true,
                    ValidIssuer = configuration["Auth:Jwt:Issuer"],
                    ValidAudience = configuration["Auth:Jwt:Audience"],
                    IssuerSigningKey = siginKey
                };
                opt.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        Console.WriteLine("OnAuthenticationFailed", context.Exception.Message);
                        return Task.CompletedTask;
                    },
                    OnTokenValidated=context =>
                    {
                        Console.WriteLine("OnTokenValidated", context.SecurityToken);
                        return Task.CompletedTask;
                    }
                };
            });
            return services;
        }
    }
}
