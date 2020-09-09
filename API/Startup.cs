using project.Application.Games;
using project.Application.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using project.Persistance;
using project.Application;
using System.Collections.Generic;


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

            

            services.AddSingleton<Messages>();
            services.AddTransient<IDatabaseService, DatabaseService>();
            services.AddTransient<IQueryHandler<GetGameListQuery, List<GameItemListDto>>, GetGameListQueryHandler>();
            services.AddTransient<IQueryHandler<GetGamesListByDisciplineQuery, List<GameItemListDto>>, GetGamesListByDisciplineQueryHandler>();

            services.AddTransient<ICommandHandler<AddGameCommand>, AddGameCommandHandler>();

            //   services.AddDbContext<DatabaseService>(opt =>
            //   opt.UseSqlServer(Configuration.GetConnectionString("SoccerConnection"))
            //   .EnableSensitiveDataLogging()
            //);

           

            services.AddTransient<IGetGameDetailsByIdQuery, GetGameDetailsByIdQuery>();
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
