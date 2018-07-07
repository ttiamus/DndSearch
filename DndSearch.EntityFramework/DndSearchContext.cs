using DndSearch.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndSearch.EntityFramework
{
    public class DndSearchContext : DbContext
    {
        public DbSet<Spell> Spells { get; set; }

        public DndSearchContext() { }

        public DndSearchContext(DbContextOptions options) : base(options)
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception)
            {
                //Should do something meaningful here                
            }
        }

        //Applied after constructor and overrides any values submitted
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            /*if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }*/

            //Used if want to implement custom retry logic
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(connectionString,options => options.ExecutionStrategy(c=>new MyExecutionStrategy(c)));
            //}
            
            //Default retry logic for SQL Server
            if (!optionsBuilder.IsConfigured)   //Only set property when not already set from constructor
            {
                var connectionString = @"Server=(localdb)\mssqllocaldb;Database=DndSearch;Trusted_Connection=True;MultipleActiveResultSets=true;";
                optionsBuilder.UseSqlServer(connectionString,options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
