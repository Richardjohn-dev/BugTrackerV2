using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Persistence.Migrations
{
    public partial class UpdateSeedUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BTUserProject");

            migrationBuilder.CreateTable(
                name: "ApplicationUserProject",
                columns: table => new
                {
                    MembersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProject", x => new { x.MembersId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserProject_AspNetUsers_MembersId",
                        column: x => x.MembersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProject_ProjectsId",
                table: "ApplicationUserProject",
                column: "ProjectsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserProject");

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

            migrationBuilder.CreateTable(
                name: "BTUserProject",
                columns: table => new
                {
                    MembersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BTUserProject", x => new { x.MembersId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_BTUserProject_AspNetUsers_MembersId",
                        column: x => x.MembersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BTUserProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BTUserProject_ProjectsId",
                table: "BTUserProject",
                column: "ProjectsId");
        }
    }
}
