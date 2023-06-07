using DMS.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Api;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<School> School { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<ClassRoom> ClassRoom { get; set; }
    public DbSet<Child> Child { get; set; }
    public DbSet<Pantry> Pantry { get; set; }
    public DbSet<Activity> Activity { get; set; }
    public DbSet<Guardian> Guardian { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<Student> Student { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>()
            .HasOne(c => c.School)
            .WithMany()
            .HasForeignKey(c => c.SchoolId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
