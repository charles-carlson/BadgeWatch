﻿// <auto-generated />
using System;
using BadgeWatch.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BadgeWatch.Migrations
{
    [DbContext(typeof(PublicRecordsContext))]
    [Migration("20231002185333_configuration")]
    partial class configuration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("BadgeWatch.Models.Officer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AppointmentDate");

                    b.Property<int>("Arrests");

                    b.Property<DateTime>("AssignmentDate");

                    b.Property<int>("BadgeNumber");

                    b.Property<string>("City");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Division");

                    b.Property<int>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Precinct");

                    b.Property<string>("Rank");

                    b.HasKey("Id");

                    b.ToTable("Officers");

                    b.HasData(
                        new { Id = 1, AppointmentDate = new DateTime(2002, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), Arrests = 34, AssignmentDate = new DateTime(2003, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), BadgeNumber = 12, City = "Somerville", CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Division = "Patrol", IsActive = 1, Name = "Richard Simmons", Precinct = "East", Rank = "Sergeant" },
                        new { Id = 2, AppointmentDate = new DateTime(2019, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), Arrests = 12, AssignmentDate = new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), BadgeNumber = 47, City = "Somerville", CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Division = "Patrol", IsActive = 1, Name = "Iluv Donetz", Precinct = "East", Rank = "Officer" },
                        new { Id = 3, AppointmentDate = new DateTime(2005, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), Arrests = 50, AssignmentDate = new DateTime(2006, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), BadgeNumber = 21, City = "Somerville", CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Division = "Patrol", IsActive = 1, Name = "Alotta Gaz", Precinct = "West", Rank = "Officer" },
                        new { Id = 4, AppointmentDate = new DateTime(2002, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Arrests = 15, AssignmentDate = new DateTime(2003, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), BadgeNumber = 19, City = "Somerville", CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Division = "Patrol", IsActive = 1, Name = "Phillis Cook", Precinct = "West", Rank = "Sergeant" }
                    );
                });

            modelBuilder.Entity("BadgeWatch.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DisciplinaryDate");

                    b.Property<string>("DisciplinaryHistory");

                    b.Property<int>("OfficerId");

                    b.HasKey("Id");

                    b.HasIndex("OfficerId");

                    b.ToTable("Records");

                    b.HasData(
                        new { Id = 1, CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryDate = new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryHistory = "Sustained Complaint of unlawful use of force, gravely injured suspect. Arrested suspect for disorderly and public intoxication. Suspended for two months without pay.", OfficerId = 1 },
                        new { Id = 2, CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryDate = new DateTime(2010, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryHistory = "Improperly discharged firearm, injuring a fellow officer. 6 months suspension", OfficerId = 1 },
                        new { Id = 3, CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryDate = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryHistory = "Filed incomplete report, omitting required information. Suspended for two weeks.", OfficerId = 2 },
                        new { Id = 4, CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryDate = new DateTime(2012, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryHistory = "Deprivation of 1st and 4th amendment rights during a traffic stop. Suspended with pay for two weeks", OfficerId = 3 },
                        new { Id = 5, CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryDate = new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryHistory = "Use of force during traffic stop. Unlawfully deploys tazer more tha 3 times towards apprehended suspect", OfficerId = 3 },
                        new { Id = 6, CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryDate = new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), DisciplinaryHistory = "N/A", OfficerId = 4 }
                    );
                });

            modelBuilder.Entity("BadgeWatch.Models.Record", b =>
                {
                    b.HasOne("BadgeWatch.Models.Officer")
                        .WithMany()
                        .HasForeignKey("OfficerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
