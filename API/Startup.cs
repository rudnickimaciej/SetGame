using Application.Games.Commands;
using Application.Games.Queries;
using project.Application.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using project.Persistance;
using Microsoft.EntityFrameworkCore;

namespace API
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

          
            services.AddTransient<IDatabaseService, DatabaseService>();

            services.AddDbContext<DatabaseService>(opt =>
            opt.UseSqlServer(Configuration.GetConnectionString("SoccerConnection"))
            .EnableSensitiveDataLogging()
         );

            services.AddTransient<IGetGamesListQuery, GetGamesListQuery>();
            services.AddTransient<IGetGamesListByDisciplineQuery, GetGamesListByDisciplineQuery>();

            services.AddTransient<IGetGameDetailsByIdQuery, GetGameDetailsByIdQuery>();
            services.AddTransient<IAddGameCommand, AddGameCommand>();
            services.AddTransient<IDeleteGameCommand, DeleteGameCommand>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
