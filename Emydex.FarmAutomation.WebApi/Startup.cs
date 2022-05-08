using System;
using System.IO;
using System.Reflection;
using Emydex.FarmAutomation.IoT.Core;
using Emydex.FarmAutomation.WebApi.DeviceWrappers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Emydex.FarmAutomation.WebApi
{
    public class Startup
    {
        #region Constructors

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Public Properties

        public IConfiguration Configuration { get; }

        #endregion

        #region Public Methods

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(options => { options.InjectStylesheet("/swagger-ui/custom.css"); });
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseSwaggerUI(options =>
                             {
                                 options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                                 options.RoutePrefix = string.Empty;
                             });

            app.UseSwagger(options => { options.SerializeAsV2 = true; });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(options =>
                                   {
                                       options.SwaggerDoc("v1", new OpenApiInfo
                                                                {
                                                                        Version = "v1",
                                                                        Title = "Emydex Farm Automation API",
                                                                        Description = "Set of APIs which allows management of farm and allows interaction with the farm automation IoT devices",
                                                                        TermsOfService = new Uri("https://emydex.com/terms"),
                                                                        Contact = new OpenApiContact
                                                                                  {
                                                                                          Name = "Emydex Web Development",
                                                                                          Url = new Uri("https://emydex.com/contact")
                                                                                  },
                                                                        License = new OpenApiLicense
                                                                                  {
                                                                                          Name = "License Info",
                                                                                          Url = new Uri("https://emydex.com/license")
                                                                                  }
                                                                        
                                                                });

                                       // using System.Reflection;
                                       var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                                       options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
                                   });

            //Register all the supported devices with the infrastructure
            IoTDeviceFactory.RegisterDevice(new AutoFarmPLC());
            IoTDeviceFactory.RegisterDevice(new RoboFarmPLC());


            //TODO : Create an instance of the AutoFarmPLC and use this instance through out
            //For the first trial we are going to be activating RoboFarmPLC device


        }

        #endregion
    }
}