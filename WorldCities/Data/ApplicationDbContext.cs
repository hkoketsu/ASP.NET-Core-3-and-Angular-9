using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCities.Data.Models;

namespace WorldCities.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(): base() { }

		public ApplicationDbContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// map entities to db table names
			modelBuilder.Entity<City>().ToTable("Cities");
			modelBuilder.Entity<Country>().ToTable("Countries");
		}

		public DbSet<City> Cities { get; set; }
		public DbSet<Country> Countries { get; set; }
	}
}
