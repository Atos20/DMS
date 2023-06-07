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
         .OnDelete(DeleteBehavior.NoAction
         );

        modelBuilder.Entity<School>().HasData(
           new School { SchoolId = 1, SchoolName = "Little Sprouts Daycare", DirectorName = "Director 1" },
           new School { SchoolId = 2, SchoolName = "Tiny Tots Childcare Center", DirectorName = "Director 2" },
           new School { SchoolId = 3, SchoolName = "Sunshine Kids Daycare", DirectorName = "Director 3" },
           new School { SchoolId = 4, SchoolName = "Happy Hearts Preschool and Daycare", DirectorName = "Director 4" },
           new School { SchoolId = 5, SchoolName = "Playful Pals Child Development Center", DirectorName = "Director 5" }
       );

        modelBuilder.Entity<ClassRoom>().HasData(
            new ClassRoom { ClassRoomId = 1, ClassRoomName = "Sunshine Room", CourseName = "Droolers", ChildCareWorker = "Maria Elena", ChildrenLimit = 10, StartAge = 0, EndAge = 1, SchoolId = 1 },
            new ClassRoom { ClassRoomId = 2, ClassRoomName = "Rainbow Room", CourseName = "Walkers", ChildCareWorker = "Francisca", ChildrenLimit = 12, StartAge = 1, EndAge = 2, SchoolId = 1 },
            new ClassRoom { ClassRoomId = 3, ClassRoomName = "Adventure Zone", CourseName = "Wabblers", ChildCareWorker = "Claudia", ChildrenLimit = 15, StartAge = 2, EndAge = 3, SchoolId = 1 },
            new ClassRoom { ClassRoomId = 4, ClassRoomName = "Little Explorers", CourseName = "Go Wild", ChildCareWorker = "Irene", ChildrenLimit = 12, StartAge = 3, EndAge = 4, SchoolId = 1 },
            new ClassRoom { ClassRoomId = 5, ClassRoomName = "Cozy Corner", CourseName = "Hikers", ChildCareWorker = "Natalia", ChildrenLimit = 10, StartAge = 4, EndAge = 5, SchoolId = 1 },
            new ClassRoom { ClassRoomId = 6, ClassRoomName = "Tiny Tots Haven", CourseName = "Dancers", ChildCareWorker = "Catalina", ChildrenLimit = 10, StartAge = 5, EndAge = 6, SchoolId = 1 }
        );

        modelBuilder.Entity<Pantry>().HasData(
            new Pantry { PantryId = 1, DiaperCount = 50, UsedDiapers = 5, ClothChangesCount = 3, NeedsClothes = false, MilkBottleCount = 5, NeedsMoreBottles = false, Sunscreen = 50.0, NeedsMoreSunscreen = false, ClassRoomId = 1 },
            new Pantry { PantryId = 2, DiaperCount = 50, UsedDiapers = 7, ClothChangesCount = 3, NeedsClothes = false, MilkBottleCount = 5, NeedsMoreBottles = false, Sunscreen = 40.0, NeedsMoreSunscreen = false, ClassRoomId = 2 }
        );

        modelBuilder.Entity<Address>().HasData(
            new Address { AddressId = 1, Street = "Street 1", City = "City 1", State = "State 1", PostalCode = "12345", Country = "USA", SchoolId = 1, GuardianId = 1 },
            new Address { AddressId = 2, Street = "Street 2", City = "City 2", State = "State 2", PostalCode = "23456", Country = "USA", SchoolId = 2, GuardianId = 2 },
            new Address { AddressId = 3, Street = "Street 3", City = "City 3", State = "State 3", PostalCode = "34567", Country = "USA", SchoolId = 3, GuardianId = 3 },
            new Address { AddressId = 4, Street = "Street 4", City = "City 4", State = "State 4", PostalCode = "45678", Country = "USA", SchoolId = 4, GuardianId = 4 },
            new Address { AddressId = 5, Street = "Street 5", City = "City 5", State = "State 5", PostalCode = "56789", Country = "USA", SchoolId = 5, GuardianId = 5 }
        );

        modelBuilder.Entity<Location>().HasData(
            new Location { Id = 1, Latitude = 12.3456, Longitude = 78.9012, AddressId = 1 },
            new Location { Id = 2, Latitude = 23.4567, Longitude = 87.6543, AddressId = 2 },
            new Location { Id = 3, Latitude = 34.5678, Longitude = 98.7654, AddressId = 3 },
            new Location { Id = 4, Latitude = 45.6789, Longitude = 76.5432, AddressId = 4 },
            new Location { Id = 5, Latitude = 56.7890, Longitude = 65.4321, AddressId = 5 }
        );

        modelBuilder.Entity<Guardian>().HasData(
            new Guardian { GuardianId = 1, Email = "guardian1@example.com", PhoneNumber = "1234567890", Name = "Guardian 1" },
            new Guardian { GuardianId = 2, Email = "guardian2@example.com", PhoneNumber = "2345678901", Name = "Guardian 2" },
            new Guardian { GuardianId = 3, Email = "guardian3@example.com", PhoneNumber = "3456789012", Name = "Guardian 3" },
            new Guardian { GuardianId = 4, Email = "guardian4@example.com", PhoneNumber = "4567890123", Name = "Guardian 4" },
            new Guardian { GuardianId = 5, Email = "guardian5@example.com", PhoneNumber = "5678901234", Name = "Guardian 5" }
        );

        modelBuilder.Entity<Activity>().HasData(
            new Activity { ActivityId = "A1", Name = "Drooling Competion", Description = "Description 1", AgeGroup = 1, MaterialsNeeded = "Materials 1", LeadBy = "Leader 1" },
            new Activity { ActivityId = "A2", Name = "Biggest Poop", Description = "Description 2", AgeGroup = 2, MaterialsNeeded = "Materials 2", LeadBy = "Leader 2" },
            new Activity { ActivityId = "A3", Name = "Loudest Cry", Description = "Description 3", AgeGroup = 3, MaterialsNeeded = "Materials 3", LeadBy = "Leader 3" },
            new Activity { ActivityId = "A4", Name = "Never Leave", Description = "Description 4", AgeGroup = 4, MaterialsNeeded = "Materials 4", LeadBy = "Leader 4" },
            new Activity { ActivityId = "A5", Name = "Feed me NOW!", Description = "Description 5", AgeGroup = 5, MaterialsNeeded = "Materials 5", LeadBy = "Leader 5" }
        );

        modelBuilder.Entity<Child>().HasData(
            new Child { ChildId = 1, Name = "Emma", Gender = "Male", LastName = "Doe", Age = 1, DateOfBirth = new DateTime(2019, 1, 1), ClassRoomId = 1, SchoolId = 1 },
            new Child { ChildId = 2, Name = "Erica", Gender = "Female", LastName = "Doe", Age = 4, DateOfBirth = new DateTime(2018, 1, 1), ClassRoomId = 1, SchoolId = 1 },
            new Child { ChildId = 3, Name = "Elisa", Gender = "Male", LastName = "Doe", Age = 5, DateOfBirth = new DateTime(2017, 1, 1), ClassRoomId = 1, SchoolId = 1 },
            new Child { ChildId = 4, Name = "Olivia", Gender = "Female", LastName = "Doe", Age = 3, DateOfBirth = new DateTime(2019, 2, 1), ClassRoomId = 1, SchoolId = 1 },
            new Child { ChildId = 5, Name = "Eva", Gender = "Male", LastName = "Doe", Age = 4, DateOfBirth = new DateTime(2018, 2, 1), ClassRoomId = 2, SchoolId = 1 },
            new Child { ChildId = 6, Name = "Nathan", Gender = "Female", LastName = "Doe", Age = 4, DateOfBirth = new DateTime(2018, 2, 1), ClassRoomId = 2, SchoolId = 1 },
            new Child { ChildId = 7, Name = "Paulina", Gender = "Female", LastName = "Doe", Age = 4, DateOfBirth = new DateTime(2018, 2, 1), ClassRoomId = 2, SchoolId = 1 },
            new Child { ChildId = 8, Name = "Fabiola", Gender = "Female", LastName = "Doe", Age = 4, DateOfBirth = new DateTime(2018, 2, 1), ClassRoomId = 2, SchoolId = 1 },
            new Child { ChildId = 9, Name = "Valentina", Gender = "Male", LastName = "Doe", Age = 4, DateOfBirth = new DateTime(2018, 2, 1), ClassRoomId = 1, SchoolId = 1 },
            new Child { ChildId = 10, Name = "Claudia", Gender = "Male", LastName = "Doe", Age = 4, DateOfBirth = new DateTime(2018, 2, 1), ClassRoomId = 1, SchoolId = 1 }
        );
    }
}