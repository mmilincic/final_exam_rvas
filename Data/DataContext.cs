using Formula.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace F1App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Domenski objekti
        public DbSet<Tim> Timovi { get; set; }
        public DbSet<Vozac> Vozaci { get; set; }
        public DbSet<Trke> Trke { get; set; }
        public DbSet<Rezultat> Rezultati { get; set; }
        public DbSet<Staza> Staze{ get; set; }

        //public DbSet<Sponzori> Sponzori { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vozac>()
            .HasOne(v => v.Tim)
            .WithMany(t => t.vozaci)
            .HasForeignKey(v => v.tim);

            modelBuilder.Entity<Tim>()
                .HasKey(t => t.timId);

            modelBuilder.Entity<Vozac>()
                .HasKey(v => v.vozacId);

            modelBuilder.Entity<Vozac>()
                .HasMany(v => v.sponzori)
                .WithMany(s => s.vozaci);

            modelBuilder.Entity<Staza>()
                .HasKey(s => s.stazaId);

            modelBuilder.Entity<Trke>()
                .HasOne(t => t.Staza)
                .WithMany(s => s.Trke)
                .HasForeignKey(t => t.staza);

        }
    }
}
