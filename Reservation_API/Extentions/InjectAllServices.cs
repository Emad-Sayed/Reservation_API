using _Service.BUSINESS;
using _Service.INTERFACES.GENERAL;
using _Service.INTERFACES.TICKET;
using _Service.Mapper;
using _Service.Vw_Model.GENERAL;
using AutoMapper;
using DB.Context;
using DB.Model.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_API.Extentions
{
    public static  class InjectAllServices
    {
        public static void InjectAll(this IServiceCollection service)
        {
            service.Inject_DbContext();
            service.Inject_Mapper();
            service.Inject_Identity();
            service.Inject_Auth();
            service.Inject_CORS();
            service.Inject_Swagger();
            service.Inject_Business();
        }
        public static void Inject_DbContext(this IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Startup.Configuration.GetConnectionString("DefaultConnection")));
        }
        public static void Inject_Identity(this IServiceCollection service)
        {
            service.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
        }
        public static void Inject_CORS(this IServiceCollection service)
        {
            service.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                    .WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .SetIsOriginAllowed((host) => true));
            });
        }
        public static void Inject_Mapper(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
        public static void Inject_Swagger(this IServiceCollection service)
        {
            service.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "My API" });
            });
        }
        public static void Inject_Auth(this IServiceCollection service)
        {
            service.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Startup.Configuration["Jwt:secretkey"])),
                    ClockSkew = TimeSpan.Zero // remove delay of token when expire
                };
                cfg.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];

                        // If the request is for our hub...
                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) && (path.StartsWithSegments("/ticket")))
                        {
                            // Read the token out of the query string
                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };
            });
        }
        public static void Inject_Business(this IServiceCollection service)
        {
            service.AddScoped<IREQUEST_RESULT, REQUEST_RESULT>();
            service.AddScoped<INOTIFICATION_SERVICE, Notification_Service>();
            service.AddScoped<ITICKET_SERVICE, Ticket_Service>();
        }
    }
}
