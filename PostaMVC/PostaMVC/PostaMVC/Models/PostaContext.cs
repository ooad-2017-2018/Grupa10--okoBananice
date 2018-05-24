using Posta.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PostaMVC.Models
{
    public class PostaContext : DbContext
    {
        public PostaContext() : base("AzureConnection")
        {

        }

        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Paket> Paket { get; set; }
        public DbSet<Postar> Postar { get; set; }
        public DbSet<Potrosac> Potrosac { get; set; }
        public DbSet<Racun> Racun { get; set; }
        public DbSet<Salterusa> Salterusa { get; set; }
        public DbSet<Uposlenik> Uposlenik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}