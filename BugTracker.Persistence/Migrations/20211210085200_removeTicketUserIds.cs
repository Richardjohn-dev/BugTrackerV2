using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class RemoveTicketUserIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c7b3bdc-745b-488c-a36a-5b494c60ba89", "b9da7138-1392-44f6-b710-3bc00baeb2f6", "User", "USER" },
                    { "22cf1fd3-77f3-41cb-b666-260fe8c0226c", "8ccae9f6-e4be-433a-8ccf-ba04e684df46", "System Administrator", "SYSTEMADMIN" },
                    { "b4bd608a-4f5f-4854-8e1f-ebb25ed54722", "948427de-09d4-48df-aaab-af98122a0dbf", "Project Administrator", "PROJECTADMIN" },
                    { "0cb7a33c-b4f5-495c-9935-97fa59528ff2", "d0800f94-47dc-44d5-8d9c-3211d3c0a443", "Tech Lead", "TECHLEAD" },
                    { "0997e05f-559d-47f9-a297-0811b3a0a5c0", "40da34f1-6054-48d5-b0c0-f62fdbcfcaac", "Developer", "DEVELOPER" }
                });

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 589, DateTimeKind.Unspecified).AddTicks(7166), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 589, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 589, DateTimeKind.Unspecified).AddTicks(7545), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 589, DateTimeKind.Unspecified).AddTicks(7547), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 589, DateTimeKind.Unspecified).AddTicks(7550), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 589, DateTimeKind.Unspecified).AddTicks(7553), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 591, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 591, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 591, DateTimeKind.Unspecified).AddTicks(143), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 591, DateTimeKind.Unspecified).AddTicks(144), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 591, DateTimeKind.Unspecified).AddTicks(145), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "TicketStatuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 12, 10, 8, 51, 59, 591, DateTimeKind.Unspecified).AddTicks(146), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0997e05f-559d-47f9-a297-0811b3a0a5c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cb7a33c-b4f5-495c-9935-97fa59528ff2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22cf1fd3-77f3-41cb-b666-260fe8c0226c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c7b3bdc-745b-488c-a36a-5b494c60ba89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4bd608a-4f5f-4854-8e1f-ebb25ed54722");

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
        }
    }
}
