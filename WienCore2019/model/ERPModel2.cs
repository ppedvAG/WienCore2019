namespace WienCore2019
{
    using System;

    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    public partial class ERPModel2 : DbContext
    {
        public IConfiguration Configuration { get; set; }

        public ERPModel2(IConfiguration _configuration, DbContextOptions<ERPModel2> options)
            : base(options)
        {
            Configuration = _configuration;
        }

        public virtual DbSet<Positionen> Positionen { get; set; }
        public virtual DbSet<Rechnung> Rechnung { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Positionen>()
                .Property(e => e.Text)
                .IsUnicode(false);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {



            if (!optionsBuilder.IsConfigured)

            {

                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("demo"));

            }

        }
    }
}
