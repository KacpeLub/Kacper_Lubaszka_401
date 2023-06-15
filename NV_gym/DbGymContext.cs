using Microsoft.EntityFrameworkCore;
using NV_gym.Models;

namespace NV_gym
{
	public class DbGymContext : DbContext
	{
		public DbGymContext(DbContextOptions<DbGymContext> options) : base(options) { }

		public DbSet<Gym> Gyms { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
