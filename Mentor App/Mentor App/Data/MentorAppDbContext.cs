using Mentor_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentor_App.Data
{
    public class MentorAppDbContext : DbContext
    {

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public MentorAppDbContext(DbContextOptions<MentorAppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PricingServices>()
                .HasKey(ps => new { ps.PricingId, ps.ServiceId });
            modelBuilder.Entity<Pricing>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            base.OnModelCreating(modelBuilder);
        }
    }
}
