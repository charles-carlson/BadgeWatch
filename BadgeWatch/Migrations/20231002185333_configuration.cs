using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BadgeWatch.Migrations
{
    public partial class configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Officers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Rank = table.Column<string>(nullable: true),
                    BadgeNumber = table.Column<int>(nullable: false),
                    Division = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Precinct = table.Column<string>(nullable: true),
                    Arrests = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false),
                    AppointmentDate = table.Column<DateTime>(nullable: false),
                    AssignmentDate = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Officers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OfficerId = table.Column<int>(nullable: false),
                    DisciplinaryHistory = table.Column<string>(nullable: true),
                    DisciplinaryDate = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Officers_OfficerId",
                        column: x => x.OfficerId,
                        principalTable: "Officers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Officers",
                columns: new[] { "Id", "AppointmentDate", "Arrests", "AssignmentDate", "BadgeNumber", "City", "CreatedAt", "Division", "IsActive", "Name", "Precinct", "Rank" },
                values: new object[] { 1, new DateTime(2002, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, new DateTime(2003, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Somerville", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol", 1, "Richard Simmons", "East", "Sergeant" });

            migrationBuilder.InsertData(
                table: "Officers",
                columns: new[] { "Id", "AppointmentDate", "Arrests", "AssignmentDate", "BadgeNumber", "City", "CreatedAt", "Division", "IsActive", "Name", "Precinct", "Rank" },
                values: new object[] { 2, new DateTime(2019, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, "Somerville", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol", 1, "Iluv Donetz", "East", "Officer" });

            migrationBuilder.InsertData(
                table: "Officers",
                columns: new[] { "Id", "AppointmentDate", "Arrests", "AssignmentDate", "BadgeNumber", "City", "CreatedAt", "Division", "IsActive", "Name", "Precinct", "Rank" },
                values: new object[] { 3, new DateTime(2005, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, new DateTime(2006, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Somerville", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol", 1, "Alotta Gaz", "West", "Officer" });

            migrationBuilder.InsertData(
                table: "Officers",
                columns: new[] { "Id", "AppointmentDate", "Arrests", "AssignmentDate", "BadgeNumber", "City", "CreatedAt", "Division", "IsActive", "Name", "Precinct", "Rank" },
                values: new object[] { 4, new DateTime(2002, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2003, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Somerville", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol", 1, "Phillis Cook", "West", "Sergeant" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "CreatedAt", "DisciplinaryDate", "DisciplinaryHistory", "OfficerId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sustained Complaint of unlawful use of force, gravely injured suspect. Arrested suspect for disorderly and public intoxication. Suspended for two months without pay.", 1 });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "CreatedAt", "DisciplinaryDate", "DisciplinaryHistory", "OfficerId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Improperly discharged firearm, injuring a fellow officer. 6 months suspension", 1 });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "CreatedAt", "DisciplinaryDate", "DisciplinaryHistory", "OfficerId" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filed incomplete report, omitting required information. Suspended for two weeks.", 2 });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "CreatedAt", "DisciplinaryDate", "DisciplinaryHistory", "OfficerId" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deprivation of 1st and 4th amendment rights during a traffic stop. Suspended with pay for two weeks", 3 });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "CreatedAt", "DisciplinaryDate", "DisciplinaryHistory", "OfficerId" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Use of force during traffic stop. Unlawfully deploys tazer more tha 3 times towards apprehended suspect", 3 });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "CreatedAt", "DisciplinaryDate", "DisciplinaryHistory", "OfficerId" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Records_OfficerId",
                table: "Records",
                column: "OfficerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Officers");
        }
    }
}
