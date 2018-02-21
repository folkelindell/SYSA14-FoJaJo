using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FoJaJo.Model;

namespace FoJaJo.DAL
{
    public class EntityContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerInGame> PlayersInGame { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Game> Games { get; set; }


        public EntityContext() : base("LuffarSchack") { }
        // Twist our database
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}