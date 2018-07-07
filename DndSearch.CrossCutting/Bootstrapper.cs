using DndSearch.Dal.Interfaces;
using DndSearch.Dal.Repositories;
using DndSearch.EntityFramework;
using DndSearch.Services.Interfaces;
using DndSearch.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndSearch.CrossCutting
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterDependencyInjection(this IServiceCollection services)
        {
            //services.AddTransient<ITopicAreaService, TopicAreaService>();
            // Add all other services here.

            services.AddScoped<ISpellService, SpellService>();
            services.AddScoped<ISpellRepo, SpellRepo>();

            return services;
        }

        public static IServiceCollection RegisterDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DndSearchContext>(options =>
            {
                options.UseSqlServer(connectionString, sqlOptions => sqlOptions.EnableRetryOnFailure());
            });

            return services;
        }
    }
}
