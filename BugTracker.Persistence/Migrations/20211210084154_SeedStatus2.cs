using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class SeedStatus2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_OwnerUserId",
                table: "Tickets");

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

            migrationBuilder.RenameColumn(
                name: "OwnerUserId",
                table: "Tickets",
                newName: "ReporterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_OwnerUserId",
                table: "Tickets",
                newName: "IX_Tickets_ReporterUserId");

            migrationBuilder.AddColumn<bool>(
                name: "Closed",
                table: "Tickets",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ef661ea-1e2e-49ec-b6ec-c37fc1abf3d7", "b8eb6da6-b15d-4208-8edc-b76f0470090d", "User", "USER" },
                    { "4f56c58d-1913-4852-a500-afd6cdaec8e8", "ef6c5505-71d5-4113-b7cb-44bb8c552f41", "System Administrator", "SYSTEMADMIN" },
                    { "2825ce85-5550-4718-8dc9-d425c4309f5b", "3757cc0d-30de-487e-a96a-1e9ad0288858", "Project Administrator", "PROJECTADMIN" },
                    { "78a31e5c-163e-440b-8feb-a05b32c4207f", "df68696f-d083-42ce-9161-5859533a3856", "Tech Lead", "TECHLEAD" },
                    { "27683f93-646d-4a7c-83b9-5a3ffa97d88f", "67f2fe1d-b448-451c-84e5-3caa93536797", "Developer", "DEVELOPER" }
                });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 691, DateTimeKind.Unspecified).AddTicks(4875), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 691, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 691, DateTimeKind.Unspecified).AddTicks(5326), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 691, DateTimeKind.Unspecified).AddTicks(5327), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 691, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 691, DateTimeKind.Unspecified).AddTicks(5331), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 692, DateTimeKind.Unspecified).AddTicks(8974), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 692, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 692, DateTimeKind.Unspecified).AddTicks(8988), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 692, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 692, DateTimeKind.Unspecified).AddTicks(8991), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 41, 53, 692, DateTimeKind.Unspecified).AddTicks(8992), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_ReporterUserId",
                table: "Tickets",
                column: "ReporterUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_ReporterUserId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ef661ea-1e2e-49ec-b6ec-c37fc1abf3d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27683f93-646d-4a7c-83b9-5a3ffa97d88f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2825ce85-5550-4718-8dc9-d425c4309f5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f56c58d-1913-4852-a500-afd6cdaec8e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78a31e5c-163e-440b-8feb-a05b32c4207f");

            migrationBuilder.DropColumn(
                name: "Closed",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "ReporterUserId",
                table: "Tickets",
                newName: "OwnerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ReporterUserId",
                table: "Tickets",
                newName: "IX_Tickets_OwnerUserId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "85216005-577a-4613-aad7-817b92dde3f7", "a32a22a4-d262-49cc-a671-a561b7bc2fb4", "User", "USER" },
                    { "19bb4b9c-91ae-418f-b261-0aef7256fced", "dc68ca7c-15dc-4137-8d0a-47b62616701a", "System Administrator", "SYSTEM ADMIN" },
                    { "4d234bff-0e0b-40ea-8759-f8d127c864a0", "3342ea9b-676e-4928-aed2-6874c8e23b7d", "Project Administrator", "PROJECT ADMIN" },
                    { "eb519668-e3aa-4857-b03b-eb7c3e8e4f6e", "1ffa3deb-d483-42ce-82f3-011b89e1cba4", "Tech Lead", "TECH LEAD" },
                    { "72c15978-6348-4df3-9e56-ca3afe5f153d", "d98d26b0-9c16-4d54-b99e-086e15e74c74", "Developer", "DEVELOPER" }
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

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5272), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5275), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5276), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 9, 5, 53, 48, 752, DateTimeKind.Unspecified).AddTicks(5277), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_OwnerUserId",
                table: "Tickets",
                column: "OwnerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
