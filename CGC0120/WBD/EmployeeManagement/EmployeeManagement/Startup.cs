using EmployeeManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false).AddXmlDataContractSerializerFormatters();
            //services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeRepository, SqlEmployeeRepository>();
            services.AddSingleton<IDepartmentRepository, DepartmentRepository>();
            services.AddDbContext<AppDBContext>(options => options.UseSqlServer(_config.GetConnectionString("EmployeeDbConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }

        //    app.Use (async(context, next) => {
        //        logger.LogInformation("MW1: imcoming request");
        //        await next();
        //        logger.LogInformation("MW1: outgoging response");
        //    });
        //    app.Use(async (context, next) => {
        //        logger.LogInformation("MW2: imcoming request");
        //        await next();
        //        logger.LogInformation("MW2: outgoging response");
        //    });
        //    app.Run(async (context) => {
        //        await context.Response.WriteAsync("MW3: Request handled and response produced");
        //        logger.LogInformation("MW3: Request handled and response produced");
        //    });
        //}
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions()
                //{
                //    SourceCodeLineCount = 5
                //};
                //app.UseDeveloperExceptionPage(developerExceptionPageOptions);
                app.UseDeveloperExceptionPage();
                //app.UseStatusCodePages();
                ////app.UseStatusCodePagesWithRedirects("/Error/{0}");
                ///app.UseStatusCodePagesWithReExecute("/Error/{0}");
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
            }

            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("foo.html");
            //app.UseDefaultFiles(defaultFilesOptions);
            //app.UseStaticFiles();

            //FileServerOptions fileServerOptions = new FileServerOptions();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
            //app.UseFileServer(fileServerOptions);
            //app.UseFileServer();

            //app.Run(async (context) => {
            //    throw new Exception("Some error processing the request");
            //    await context.Response.WriteAsync("Hello world"); 
            //});
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routers => {
                routers.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            //app.UseMvc(routers =>
            //{
            //    routers.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
