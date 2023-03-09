using CORE.Api;
using CORE.Database.IRepository;
using CORE.Database.Repository;
using CORE.Service.IService;
using CORE.Service.Service;
using COREAPI.DATA;
using DALayer.IRepository;
using DALayer.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Service.IService;
using Service.Service;

namespace COREAPI
{
    public class Startup
    {
        public string ConnectionString { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("DefaultConnectionString");
        }

        public IConfiguration Configuration { get; }    //inject the configuration like app-json 

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();    //add mvc framework,Able to handle http request. 
            services.AddDbContext<BookDBContext>(options => options.UseSqlServer(ConnectionString)); //enables to interact with database through Generic class
            services.AddTransient<ExceptionMiddleware>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "COREAPI", Version = "v1" });
            });

            var config = new AutoMapper.MapperConfiguration(c =>
            {
                c.AddProfile(new ApplicationProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)   //This is middleware pipeline handler
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //This cathces the exceptions during http request 
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "COREAPI v1"));
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>      //This maps the request with the controller and action method
                             {
                                 endpoints.MapControllers();
                             });
        }
    }
}
