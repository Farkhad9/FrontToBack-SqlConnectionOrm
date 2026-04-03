using Microsoft.EntityFrameworkCore;

namespace Mentor_App.Data
{
    public class MentorAppDbContext : DbContext
    {
        public MentorAppDbContext(DbContextOptions<MentorAppDbContext> options) : base(options)
        {
        }
    }
}
