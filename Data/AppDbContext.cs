using ConferenceManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ConferenceManagementSystem.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
