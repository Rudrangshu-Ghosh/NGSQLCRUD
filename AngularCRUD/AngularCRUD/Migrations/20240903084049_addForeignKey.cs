using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularCRUD.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Departments_DeptidDid",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DeptidDid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DeptidDid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DeptidDid",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DeptidDid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeptidDid",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Deptid",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Deptid",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Deptid",
                table: "Customers",
                column: "Deptid");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Departments_Deptid",
                table: "Customers",
                column: "Deptid",
                principalTable: "Departments",
                principalColumn: "Did");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Departments_Deptid",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Deptid",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Deptid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Deptid",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "DeptidDid",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeptidDid",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DeptidDid",
                table: "Employees",
                column: "DeptidDid");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DeptidDid",
                table: "Customers",
                column: "DeptidDid");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Departments_DeptidDid",
                table: "Customers",
                column: "DeptidDid",
                principalTable: "Departments",
                principalColumn: "Did",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DeptidDid",
                table: "Employees",
                column: "DeptidDid",
                principalTable: "Departments",
                principalColumn: "Did",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
