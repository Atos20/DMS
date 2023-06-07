using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DMS.Api.Migrations
{
    /// <inheritdoc />
    public partial class seedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Guardian_GuardianId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_School_SchoolId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_GuardianId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_SchoolId",
                table: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Address",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GuardianId",
                table: "Address",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ActivityId", "AgeGroup", "Description", "LeadBy", "MaterialsNeeded", "Name" },
                values: new object[,]
                {
                    { "A1", 1, "Description 1", "Leader 1", "Materials 1", "Drooling Competion" },
                    { "A2", 2, "Description 2", "Leader 2", "Materials 2", "Biggest Poop" },
                    { "A3", 3, "Description 3", "Leader 3", "Materials 3", "Loudest Cry" },
                    { "A4", 4, "Description 4", "Leader 4", "Materials 4", "Never Leave" },
                    { "A5", 5, "Description 5", "Leader 5", "Materials 5", "Feed me NOW!" }
                });

            migrationBuilder.InsertData(
                table: "Guardian",
                columns: new[] { "GuardianId", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "guardian1@example.com", "Guardian 1", "1234567890" },
                    { 2, "guardian2@example.com", "Guardian 2", "2345678901" },
                    { 3, "guardian3@example.com", "Guardian 3", "3456789012" },
                    { 4, "guardian4@example.com", "Guardian 4", "4567890123" },
                    { 5, "guardian5@example.com", "Guardian 5", "5678901234" }
                });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "SchoolId", "DirectorName", "SchoolName" },
                values: new object[,]
                {
                    { 1, "Director 1", "Little Sprouts Daycare" },
                    { 2, "Director 2", "Tiny Tots Childcare Center" },
                    { 3, "Director 3", "Sunshine Kids Daycare" },
                    { 4, "Director 4", "Happy Hearts Preschool and Daycare" },
                    { 5, "Director 5", "Playful Pals Child Development Center" }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressId", "City", "Country", "GuardianId", "PostalCode", "SchoolId", "State", "Street" },
                values: new object[,]
                {
                    { 1, "City 1", "USA", 1, "12345", 1, "State 1", "Street 1" },
                    { 2, "City 2", "USA", 2, "23456", 2, "State 2", "Street 2" },
                    { 3, "City 3", "USA", 3, "34567", 3, "State 3", "Street 3" },
                    { 4, "City 4", "USA", 4, "45678", 4, "State 4", "Street 4" },
                    { 5, "City 5", "USA", 5, "56789", 5, "State 5", "Street 5" }
                });

            migrationBuilder.InsertData(
                table: "ClassRoom",
                columns: new[] { "ClassRoomId", "ChildCareWorker", "ChildrenLimit", "ClassRoomName", "CourseName", "EndAge", "SchoolId", "StartAge" },
                values: new object[,]
                {
                    { 1, "Maria Elena", 10, "Sunshine Room", "Droolers", 1, 1, 0 },
                    { 2, "Francisca", 12, "Rainbow Room", "Walkers", 2, 1, 1 },
                    { 3, "Claudia", 15, "Adventure Zone", "Wabblers", 3, 1, 2 },
                    { 4, "Irene", 12, "Little Explorers", "Go Wild", 4, 1, 3 },
                    { 5, "Natalia", 10, "Cozy Corner", "Hikers", 5, 1, 4 },
                    { 6, "Catalina", 10, "Tiny Tots Haven", "Dancers", 6, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "Child",
                columns: new[] { "ChildId", "Age", "ClassRoomId", "DateOfBirth", "Discriminator", "Gender", "LastName", "Name", "SchoolId" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Male", "Doe", "Emma", 1 },
                    { 2, 4, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Female", "Doe", "Erica", 1 },
                    { 3, 5, 1, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Male", "Doe", "Elisa", 1 },
                    { 4, 3, 1, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Female", "Doe", "Olivia", 1 },
                    { 5, 4, 2, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Male", "Doe", "Eva", 1 },
                    { 6, 4, 2, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Female", "Doe", "Nathan", 1 },
                    { 7, 4, 2, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Female", "Doe", "Paulina", 1 },
                    { 8, 4, 2, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Female", "Doe", "Fabiola", 1 },
                    { 9, 4, 1, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Male", "Doe", "Valentina", 1 },
                    { 10, 4, 1, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child", "Male", "Doe", "Claudia", 1 }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "AddressId", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, 1, 12.345599999999999, 78.901200000000003 },
                    { 2, 2, 23.456700000000001, 87.654300000000006 },
                    { 3, 3, 34.567799999999998, 98.7654 },
                    { 4, 4, 45.678899999999999, 76.543199999999999 },
                    { 5, 5, 56.789000000000001, 65.432100000000005 }
                });

            migrationBuilder.InsertData(
                table: "Pantry",
                columns: new[] { "PantryId", "ClassRoomId", "ClothChangesCount", "DiaperCount", "MilkBottleCount", "MinimunRequiredBottles", "MinimunRequiredChanges", "MinimunRequiredDiapers", "NeedsClothes", "NeedsMoreBottles", "NeedsMoreSunscreen", "Sunscreen", "UsedDiapers" },
                values: new object[,]
                {
                    { 1, 1, 3, 50, 5, 3, 3, 10, false, false, false, 50.0, 5 },
                    { 2, 2, 3, 50, 5, 3, 3, 10, false, false, false, 40.0, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_GuardianId",
                table: "Address",
                column: "GuardianId",
                unique: true,
                filter: "[GuardianId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Address_SchoolId",
                table: "Address",
                column: "SchoolId",
                unique: true,
                filter: "[SchoolId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Guardian_GuardianId",
                table: "Address",
                column: "GuardianId",
                principalTable: "Guardian",
                principalColumn: "GuardianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_School_SchoolId",
                table: "Address",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "SchoolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Guardian_GuardianId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_School_SchoolId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_GuardianId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_SchoolId",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: "A1");

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: "A2");

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: "A3");

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: "A4");

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: "A5");

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Child",
                keyColumn: "ChildId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClassRoom",
                keyColumn: "ClassRoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClassRoom",
                keyColumn: "ClassRoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClassRoom",
                keyColumn: "ClassRoomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClassRoom",
                keyColumn: "ClassRoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pantry",
                keyColumn: "PantryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pantry",
                keyColumn: "PantryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClassRoom",
                keyColumn: "ClassRoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClassRoom",
                keyColumn: "ClassRoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guardian",
                keyColumn: "GuardianId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guardian",
                keyColumn: "GuardianId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guardian",
                keyColumn: "GuardianId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Guardian",
                keyColumn: "GuardianId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Guardian",
                keyColumn: "GuardianId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "SchoolId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "SchoolId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "SchoolId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "SchoolId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "SchoolId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GuardianId",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_GuardianId",
                table: "Address",
                column: "GuardianId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_SchoolId",
                table: "Address",
                column: "SchoolId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Guardian_GuardianId",
                table: "Address",
                column: "GuardianId",
                principalTable: "Guardian",
                principalColumn: "GuardianId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_School_SchoolId",
                table: "Address",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
