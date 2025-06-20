using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compaines",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compaines", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CompanyId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Employees_Compaines_CompanyId1",
                        column: x => x.CompanyId1,
                        principalTable: "Compaines",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Compaines",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("70094f01-5669-4cc4-807c-dfdd4c9767c0"), "312 Forest Avenue, BF 923", "USA", "Admin_Solutions Ltd" });

            migrationBuilder.InsertData(
                table: "Compaines",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("aee463b1-87db-4931-b04f-f5e2e64eeee6"), "583 Wall Dr. Gwynn Oak, MD 21207", "USA", "IT_Solutions Ltd" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "CompanyId", "Age", "CompanyId1", "Name", "Position" },
                values: new object[] { new Guid("394a480b-3131-4d31-bddd-6aaa8a687db0"), 26, new Guid("aee463b1-87db-4931-b04f-f5e2e64eeee6"), "Sam Raiden", "Software Developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "CompanyId", "Age", "CompanyId1", "Name", "Position" },
                values: new object[] { new Guid("3cea0a3a-0bc8-4e82-ae1d-87b0d83a8f46"), 26, new Guid("aee463b1-87db-4931-b04f-f5e2e64eeee6"), "Sam Raiden", "Software Developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "CompanyId", "Age", "CompanyId1", "Name", "Position" },
                values: new object[] { new Guid("4100a7b7-317e-4835-aaf7-a60888578634"), 35, new Guid("70094f01-5669-4cc4-807c-dfdd4c9767c0"), "Kan Miller", "Administrator" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId1",
                table: "Employees",
                column: "CompanyId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Compaines");
        }
    }
}
