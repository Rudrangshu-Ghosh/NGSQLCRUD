using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularCRUD.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Did = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Did);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Doj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    DepartmentDid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Cid);
                    table.ForeignKey(
                        name: "FK_Customers_Departments_DepartmentDid",
                        column: x => x.DepartmentDid,
                        principalTable: "Departments",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Doj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    DepartmentDid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Eid);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentDid",
                        column: x => x.DepartmentDid,
                        principalTable: "Departments",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Eid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DepartmentDid",
                table: "Customers",
                column: "DepartmentDid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDid",
                table: "Employees",
                column: "DepartmentDid");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_EmployeeId",
                table: "Skills",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
