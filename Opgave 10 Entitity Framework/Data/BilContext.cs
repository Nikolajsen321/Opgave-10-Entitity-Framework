using Microsoft.EntityFrameworkCore;
using Opgave_10_Entitity_Framework.Models;

namespace Opgave_10_Entitity_Framework.Data
{
    public class BilContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-CP8PKIBC\\SQLEXPRESS;Initial Catalog=Biler1;Integrated Security=SSPI; TrustServerCertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // send data for bil
            modelBuilder.Entity<Bil>().HasData(new Bil[] {
                new Bil{ BILID = -1, Name = "Ford", Weight = 1400,EjerID = -1}
            });
            //Send data for Ejer
            modelBuilder.Entity<Ejer>().HasData(new Ejer[] {
                new Ejer{ EjerID = -1,Navn = "Hans" }
            });

            //Send data for fly 
            modelBuilder.Entity<Fly>().HasData(new Fly[]
            {
                new Fly{FlyID =1,Model ="Cessna"},
                new Fly{FlyID =2,Model="Piper" }
            });

            modelBuilder.Entity<Personer>().HasData(new Personer[]
            {
                new Personer{PersonID = 1,Name="Mikkel Bang"},
                new Personer{PersonID = 2,Name="Benjamin" }
            });



			// https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many

			// Mange-til-mange relation mellem Fly og Personer
			modelBuilder.Entity<Fly>()
		.HasMany(f => f.Ejere)
		.WithMany(p => p.FlyEjet)
		.UsingEntity<Dictionary<string, object>>(
			"PersonFly",  // Navn på krydstabel
			r => r.HasOne<Personer>().WithMany().HasForeignKey("PersonID"),
			l => l.HasOne<Fly>().WithMany().HasForeignKey("FlyID"),
			j =>
			{
				// Seed data til krydstabellen
				j.HasData(
					new { FlyID = 1, PersonID = 1 },  // Mikkel Bang ejer Cessna
					new { FlyID = 1, PersonID = 2 },  // Benjamin ejer også Cessna
					new { FlyID = 2, PersonID = 2 }   // Benjamin ejer Piper
				);
			}
		);


		}
		public DbSet<Bil> Biler { get; set; }
        public DbSet<Ejer> Ejer { get; set; }   
        public DbSet<Forretning> Forretning { get; set; }

        public DbSet<Personer> Personer { get; set; }

        public DbSet<Fly> Fly { get; set; }

    }
}
