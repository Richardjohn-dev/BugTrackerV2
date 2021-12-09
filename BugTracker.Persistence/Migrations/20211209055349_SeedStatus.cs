using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class SeedStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "110236ed-9c17-4eee-a25f-5c1f22328acf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74f8368a-0348-48d9-a192-87db4d908552");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1992992-f48c-4d0b-962f-27e2f18b0832");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d42f7529-2513-49c2-9199-81f758058755");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbc6bb9a-a6cc-4746-a329-ff91216ac776");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d234bff-0e0b-40ea-8759-f8d127c864a0", "3342ea9b-676e-4928-aed2-6874c8e23b7d", "Project Administrator", "PROJECT ADMIN" },
                    { "72c15978-6348-4df3-9e56-ca3afe5f153d", "d98d26b0-9c16-4d54-b99e-086e15e74c74", "Developer", "DEVELOPER" },
                    { "85216005-577a-4613-aad7-817b92dde3f7", "a32a22a4-d262-49cc-a671-a561b7bc2fb4", "User", "USER" },
                    { "19bb4b9c-91ae-418f-b261-0aef7256fced", "dc68ca7c-15dc-4137-8d0a-47b62616701a", "System Administrator", "SYSTEM ADMIN" },
                    { "eb519668-e3aa-4857-b03b-eb7c3e8e4f6e", "1ffa3deb-d483-42ce-82f3-011b89e1cba4", "Tech Lead", "TECH LEAD" }
                });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 751, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 751, DateTimeKind.Unspecified).AddTicks(3471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 751, DateTimeKind.Unspecified).AddTicks(3475), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 751, DateTimeKind.Unspecified).AddTicks(3476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 751, DateTimeKind.Unspecified).AddTicks(3477), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 751, DateTimeKind.Unspecified).AddTicks(3478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "TicketStatuses",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "LastModifiedBy", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 5, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5276), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Closed" },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5275), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Resolved" },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 0, 0, 0, 0)), null, null, "In Progress" },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5272), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Draft" },
                    { 6, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5277), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Reopened" },
                    { 1, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Unassigned" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19bb4b9c-91ae-418f-b261-0aef7256fced");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d234bff-0e0b-40ea-8759-f8d127c864a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72c15978-6348-4df3-9e56-ca3afe5f153d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85216005-577a-4613-aad7-817b92dde3f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb519668-e3aa-4857-b03b-eb7c3e8e4f6e");

            migrationBuilder.DeleteData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "74f8368a-0348-48d9-a192-87db4d908552", "62d1ffec-ebd0-4dbe-bd0f-2c318c6dac47", "User", "USER" },
                    { "a1992992-f48c-4d0b-962f-27e2f18b0832", "f9af060f-de91-4274-8cd2-6091814a4606", "System Administrator", "SYSTEM ADMIN" },
                    { "d42f7529-2513-49c2-9199-81f758058755", "2216f14c-4791-426f-84fb-e996108bd9d9", "Project Administrator", "PROJECT ADMIN" },
                    { "110236ed-9c17-4eee-a25f-5c1f22328acf", "65b1a359-2c4f-4af4-a1fe-2bfdcf009488", "Tech Lead", "TECH LEAD" },
                    { "dbc6bb9a-a6cc-4746-a329-ff91216ac776", "20b206f5-6bd7-42f9-a856-1c67de564e77", "Developer", "DEVELOPER" }
                });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5215), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5219), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
