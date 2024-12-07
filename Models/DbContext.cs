using Microsoft.EntityFrameworkCore;

namespace Mailroom.Models;

public class MailroomDbContext : DbContext
{
    public MailroomDbContext(DbContextOptions<MailroomDbContext> options)
            : base(options)
    {

    }
    public DbSet<Package> Packages {get; set;} = null!;
    public DbSet<Resident> Residents {get; set;} = null!;
    public DbSet<StaffLogin> StaffLogins {get; set;} = null!;
    public DbSet<UnknownPackage> UnknownPackages {get; set;} = null!;
    
}