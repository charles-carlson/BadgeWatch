using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BadgeWatch.Models 
{
    public class PublicRecordsContext : DbContext
    {
        public DbSet<Officer> Officers { get; set; }
        public DbSet<Record> Records { get; set; }

        //public string DbPath { get; }
        public PublicRecordsContext()
        {

           // var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "sqldatabase.db");
        }
        public PublicRecordsContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=LocalDatabase.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Officer>()
                .HasMany<Record>()
                .WithOne()
                .HasForeignKey(e => e.OfficerId)
                .IsRequired();
            modelBuilder.Entity<Officer>().HasData(
                new Officer {
                    Id =1,
                    Name ="Richard Simmons",
                    Rank ="Sergeant",
                    BadgeNumber =12,
                    Division ="Patrol",
                    City="Somerville",
                    Precinct="East",
                    Arrests=34,
                    IsActive=1,
                    AppointmentDate=new DateTime(2002,2,14),
                    AssignmentDate=new DateTime(2003,5,8)
                },
                new Officer
                {
                    Id = 2,
                    Name = "Iluv Donetz",
                    Rank = "Officer",
                    BadgeNumber = 47,
                    Division = "Patrol",
                    City = "Somerville",
                    Precinct = "East",
                    Arrests = 12,
                    IsActive = 1,
                    AppointmentDate = new DateTime(2019, 7, 24),
                    AssignmentDate = new DateTime(2020, 6, 10)
                },
                new Officer
                {
                    Id = 3,
                    Name = "Alotta Gaz",
                    Rank = "Officer",
                    BadgeNumber = 21,
                    Division = "Patrol",
                    City = "Somerville",
                    Precinct = "West",
                    Arrests = 50,
                    IsActive = 1,
                    AppointmentDate = new DateTime(2005, 3, 5),
                    AssignmentDate = new DateTime(2006, 1, 10)
                },
                new Officer
                {
                    Id = 4,
                    Name = "Phillis Cook",
                    Rank = "Sergeant",
                    BadgeNumber = 19,
                    Division = "Patrol",
                    City = "Somerville",
                    Precinct = "West",
                    Arrests = 15,
                    IsActive = 1,
                    AppointmentDate = new DateTime(2002, 9, 12),
                    AssignmentDate = new DateTime(2003, 11, 13)
                }
                );
            modelBuilder.Entity<Record>()
                .HasData(
                new Record
                {
                    Id = 1,
                    OfficerId = 1,
                    DisciplinaryHistory = "Sustained Complaint of unlawful use of force, gravely injured suspect. Arrested suspect for disorderly and public intoxication. Suspended for two months without pay.",
                    DisciplinaryDate = new DateTime(2004, 1, 1),
                },
                new Record
                {
                    Id = 2,
                    OfficerId = 1,
                    DisciplinaryHistory = "Improperly discharged firearm, injuring a fellow officer. 6 months suspension",
                    DisciplinaryDate = new DateTime(2010, 4, 21)
                },
                new Record
                {
                    Id = 3,
                    OfficerId = 2,
                    DisciplinaryHistory = "Filed incomplete report, omitting required information. Suspended for two weeks.",
                    DisciplinaryDate = new DateTime(2021, 6, 1)
                },
                new Record
                {
                    Id = 4,
                    OfficerId = 3,
                    DisciplinaryHistory = "Deprivation of 1st and 4th amendment rights during a traffic stop. Suspended with pay for two weeks",
                    DisciplinaryDate = new DateTime(2012, 8, 17)
                },
                new Record
                {
                    Id = 5,
                    OfficerId = 3,
                    DisciplinaryHistory = "Use of force during traffic stop. Unlawfully deploys tazer more tha 3 times towards apprehended suspect",
                    DisciplinaryDate = new DateTime(2015, 3, 14)
                },
                new Record
                {
                    Id = 6,
                    OfficerId = 4,
                    DisciplinaryHistory = "N/A",
                    DisciplinaryDate = new DateTime(2023, 9, 29)
                }
                );
        }
    }
}
