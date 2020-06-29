// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BookStore.ApplicationBusiness.Interface;
    using BookStore.ApplicationBusiness.Services;
    using BookStore.Repository;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
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
    /// Startup class
    /// </summary>
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            ////Database connection
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Connection")));

            ////Default Security Service
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            //// setting timespan for tokens
            services.Configure<DataProtectionTokenProviderOptions>(opt =>
            opt.TokenLifespan = TimeSpan.FromHours(2));

            ////Registering the classes here
            services.AddTransient<IApplicationUserManager, ApplicationUserManagerImpl>();
            services.AddTransient<IBookManager, BookManagerImpl>();
            services.AddTransient<IBookStoreManager, BooksStoreManagerImpl>();
            //// Identity Classes
            services.AddTransient<UserManager<IdentityUser>>();
            services.AddTransient<SignInManager<IdentityUser>>();

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
        }

        //// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //// Using the Authentication
            app.UseAuthentication();

            loggerFactory.AddFile("Logs/myapp-{Date}.txt");

            //// Using the Swagger
            app.UseSwagger();
            //// Setting up the Swagger Endpoints

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/V2/Swagger.json", "TestApplication");
            });

            app.UseMvc();
        }
    }
}
