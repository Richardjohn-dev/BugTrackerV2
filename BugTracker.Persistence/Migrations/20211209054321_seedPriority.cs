using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class seedPriority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f94932a-72ef-4aaf-9676-c34e2b64207d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "198c03eb-5eae-43f5-82f4-0bc96ecd5186");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1befc09a-c60e-4afc-ada1-30269c8bf076");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee8b566c-496e-4c89-a0f4-1aa6a4ff74d6");

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

            migrationBuilder.InsertData(
                table: "TicketPriorities",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "LastModifiedBy", "LastModifiedDate", "Priority" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4152), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Trivial" },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4914), new TimeSpan(0, 0, 0, 0, 0)), null, null, null },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 0, 0, 0, 0)), null, null, null },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4921), new TimeSpan(0, 0, 0, 0, 0)), null, null, null },
                    { 5, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4923), new TimeSpan(0, 0, 0, 0, 0)), null, null, null },
                    { 6, null, new DateTimeOffset(new DateTime(2021, 12, 9, 5, 43, 21, 308, DateTimeKind.Unspecified).AddTicks(4924), new TimeSpan(0, 0, 0, 0, 0)), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "LastModifiedBy", "LastModifiedDate", "Type" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Bug" },
                    { 2, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Task" },
                    { 3, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Improvement" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TicketPriorities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1befc09a-c60e-4afc-ada1-30269c8bf076", "b4f96a49-98e0-452f-9720-41913a2691d3", "User", "USER" },
                    { "0f94932a-72ef-4aaf-9676-c34e2b64207d", "a01cde1e-d211-4609-ae97-c6d5b9656250", "System Administrator", "SYSTEM ADMIN" },
                    { "198c03eb-5eae-43f5-82f4-0bc96ecd5186", "037e1128-f827-4396-8fa7-a439571ae98f", "Project Administrator", "PROJECT ADMIN" },
                    { "ee8b566c-496e-4c89-a0f4-1aa6a4ff74d6", "65428b4a-fdec-4bd6-a1e3-e05341670c91", "Developer", "DEVELOPER" }
                });
        }
    }
}
