using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MSSA_CAD_Project_Lugias_Lair.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace MSSA_CAD_Project_Lugias_Lair
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();//
            services.AddSession();//
            services.AddTransient<IAbility,EFAbilityRepository>();
            services.AddTransient<ICharacteristic, EFCharacteristicRepository>();
            services.AddTransient<ICustomPokemon, EFCustomPokemonRepository>();
            services.AddTransient<IHeldItem, EFHeldItemRepository>();
            services.AddTransient<INature, EFNatureRepository>();
            services.AddTransient<IPictureFull, EFPictureFullRepository>();
            services.AddTransient<IPictureSprite, EFPictureSpriteRepository>();
            services.AddTransient<IPictureTrainerSprite, EFPictureTrainerSpriteRepository>();
            services.AddTransient<IPokedexEntry, EFPokedexEntryRepository>();
            services.AddTransient<IPokemon, EFPokemonRepository>();
            services.AddTransient<IPokemonHasAbility, EFPokemonHasAbilityRepository>();
            services.AddTransient<IPokemonLearnsMove, EFPokemonLearnsMoveRepository>();
            services.AddTransient<IPokemonMove, EFPokemonMoveRepository>();
            services.AddTransient<IPokemonType, EFPokemonTypeRepository>();
            services.AddTransient<ITeamBase, EFTeamBaseRepository>();
            services.AddTransient<ITeamVgc, EFTeamVgcRepository>();
            services.AddTransient<IVgcplayer, EFVgcplayerRepository>();
            services.AddDbContext<LugiasLair_DB_ProjectContext>
                (options => options.UseSqlServer(Configuration["Data:LugiasLairDB:ConnectionString"]));
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            app.UseStaticFiles();
            app.UseSession();//
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Vgcplayer}/{action=SignIn}");
            });

        }
    }
}
