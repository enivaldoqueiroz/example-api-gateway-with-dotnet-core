using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace API.Gateway.Extensions
{
    public static class AuthenticationExtensions
    {
        public static IServiceCollection AddAuthenticationJWTBearer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidateAudience = true,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,

                            ValidIssuer = configuration["Jwt:Issuer"],
                            ValidAudience = configuration["Jwt:Audience"],
                            IssuerSigningKey = new SymmetricSecurityKey
                                (Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
                        };
                    });

            return services;
        }

        public static IApplicationBuilder UseAuthenticationJWTBearer(this IApplicationBuilder app)
        {
            app.UseAuthentication();

            return app;
        }
    }
}
