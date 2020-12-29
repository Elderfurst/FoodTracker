using FoodTracker.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodTracker.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<FoodEntry> FoodEntries { get; set; }
		public DbSet<FoodEntryTag> FoodEntryTags { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
	}
}
