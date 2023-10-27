using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mike.InfraEstructure.CrossCutting.InversionOfControl;
using Mike.InfraEstructure.CrossCutting.Notifications;
using Mike.InfraEstructure.Data.Context;
using Mike.Interface.Mapper;
using Microsoft.OpenApi.Models;

namespace Mike
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("mike");

            services.AddControllers();

            services.AddMvc(config => 
            {
                config.Filters.Add<NotificationFilter>();
            });

            services.AddDbContext<MikeDBContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            AddAutoMapper(services);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mike API", Version = "v1" });
            });

            services.AddRepository();
            services.AddServices();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mike Api");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void AddAutoMapper(IServiceCollection services)
        {
            MapperConfiguration mappingConfig = AutoMapperConfig.RegisterMaps();
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
