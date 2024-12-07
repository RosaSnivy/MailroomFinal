using Microsoft.EntityFrameworkCore;

namespace Mailroom.Models;

public class MailroomDbContext : DbContext
{
    public MailroomDbContext(DbContextOptions<MailroomDbContext> options)
            : base(options)
    {

    }
    public DbSet<Package>? Packages {get; set;}
    public DbSet<Resident>? Residents {get; set;}
    public DbSet<StaffLogin>? StaffLogins {get; set;}
    public DbSet<UnknownPackage>? UnknownPackages {get; set;}
    
}