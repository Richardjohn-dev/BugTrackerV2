using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class PriorityFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55cb7329-8181-4f1b-84f2-74cea7ae9156");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba96fbc8-39a5-4412-b3ae-7e88c21744ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2b49149-e43c-4ea5-b03f-982ba5ed56da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d91cc6e3-6631-46eb-8f47-1238f1dc3f51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efd2d6c1-7789-41a0-b557-3c64156ae975");

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
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 0, 0, 0, 0)), "Low" });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5215), new TimeSpan(0, 0, 0, 0, 0)), "Medium" });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, 0, 0, 0, 0)), "High" });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 0, 0, 0, 0)), "Critical" });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 45, 10, 144, DateTimeKind.Unspecified).AddTicks(5219), new TimeSpan(0, 0, 0, 0, 0)), "Blocker" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "d91cc6e3-6631-46eb-8f47-1238f1dc3f51", "74c5c3c7-2c1b-455c-ac3e-7d3ffb0530f9", "User", "USER" },
                    { "ba96fbc8-39a5-4412-b3ae-7e88c21744ac", "adf66ebc-4ed6-490b-9245-bf6ddf8c71d5", "System Administrator", "SYSTEM ADMIN" },
                    { "55cb7329-8181-4f1b-84f2-74cea7ae9156", "a1f00d57-6ab5-479f-95ee-41525ee0dd25", "Project Administrator", "PROJECT ADMIN" },
                    { "efd2d6c1-7789-41a0-b557-3c64156ae975", "3937bec7-5732-420b-b85e-368b92510851", "Tech Lead", "TECH LEAD" },
                    { "c2b49149-e43c-4ea5-b03f-982ba5ed56da", "fba5152c-2a97-419c-a329-9493c6ab3311", "Developer", "DEVELOPER" }
                });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4914), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4921), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4923), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Priority" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4924), new TimeSpan(0, 0, 0, 0, 0)), null });
        }
    }
}
