using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FoJaJo.Model
{
    public class GameContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        //public DbSet<PlayerInGame> PlayersInGame { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Game> Games { get; set; }


        public GameContext() : base("LuffarSchack") { }
        // Twist our database
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}