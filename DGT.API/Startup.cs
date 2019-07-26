using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGT.Domain.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using AutoMapper;
using DGT.Services.Abstract;
using DGT.Services.Services;
using DGT.Data.Abstract;
using DGT.Data.Repositories;

namespace DGT.API
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
            services.AddDbContext<DGTContext>(opt => opt.UseInMemoryDatabase());
       

            // Unit Of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Repositories
            services.AddScoped<IConductorRespository, ConductorRespository>();
            services.AddScoped<ITipoInfraccionRespository, TipoInfraccionRepository>();
            services.AddScoped<IInfraccionRespository, InfraccionRepository>();
            services.AddScoped<IVehiculoRespository, VehiculoRespository>();

            //services
            services.AddScoped<IConductorService, ConductorService>();
            services.AddScoped<ITipoInfraccionService, TipoInfraccionService>();
            services.AddScoped<IInfraccionService, InfraccionService>();
            services.AddScoped<IVehiculoService, VehiculoService>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressUseValidationProblemDetailsForInvalidModelStateResponses = true;

            });
            var key = Encoding.ASCII.GetBytes(Configuration.GetValue<string>("SecretKey"));

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            
            services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }



            app.UseAuthentication();
            app.UseMvc();
        }

    }
}
