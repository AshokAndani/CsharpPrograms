// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ApplicationBusiness.Interfaces;
    using ApplicationBusiness.Services;
    using ApplicationRepository.Context;
    using ApplicationRepository.Interfaces;
    using ApplicationRepository.Services;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using Swashbuckle.AspNetCore.Filters;
    using Swashbuckle.AspNetCore.Swagger;
    /// <summary>
    /// this class holds the middlewares and the registered Services
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            ////Database connection
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Connection"),
            p => p.MigrationsAssembly("FundooAPI")));

            ////Default Security Service
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            //// setting timespan for tokens
            services.Configure<DataProtectionTokenProviderOptions>(opt =>
            opt.TokenLifespan = TimeSpan.FromHours(2));

            ////Registering the classes here
            services.AddTransient<IApplicationUserManager, ApplicationUserManagerImpl>();

            //// Identity Classes
            services.AddTransient<UserManager<IdentityUser>>();
            services.AddTransient<SignInManager<IdentityUser>>();

            //// for Labels
            services.AddTransient<ILabelsRepository, LabelsRepositoryImpl>();
            services.AddTransient<ILabelManager, LabelManagerImpl>();

            /// for Notes
            services.AddTransient<INotesRepository, NotesRepositoryImpl>();
            services.AddTransient<INotesManager, NotesManagerImpl>();

            ///Jwt security Service
            var secretKey = Configuration["Jwt:_key"];
            var symmerticKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:_url"],
                    ValidAudience = Configuration["Jwt:_url"],
                    IssuerSigningKey = symmerticKey,
                    RequireExpirationTime = true
                };
            });

            ////Adding the Swagger
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("V2", new Swashbuckle.AspNetCore.Swagger.Info { Title = "FundooApplication", Version = "V2" });
                
                //// this service handles the jwt token suppying in headers
                options.AddSecurityDefinition("oauth2", new ApiKeyScheme
                {
                    Description = "Using the jwt bearer token",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            //// Adding Redis cache 
            services.AddDistributedRedisCache(options=>
            {
                options.Configuration = "localhost:6379";
                options.InstanceName = "FundooNotes";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {


                app.UseDeveloperExceptionPage();
            }

            //// Using the Authentication
            app.UseAuthentication();

            app.UseMvc();
            //// Using the Swagger
            app.UseSwagger();
            //// Setting up the Swagger Endpoints
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/V2/Swagger.json", "FundooApplication");
            });
        }
    }
}
