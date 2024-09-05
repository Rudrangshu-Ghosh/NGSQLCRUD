using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularCRUD.Migrations
{
    /// <inheritdoc />
    public partial class FinalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Departments_DepartmentDid",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDid",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Employees_EmployeeId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_EmployeeId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentDid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DepartmentDid",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DepartmentDid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentDid",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Employees",
                newName: "DeptidDid");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Customers",
                newName: "DeptidDid");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeEid",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_EmployeeEid",
                table: "Skills",
                column: "EmployeeEid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Employees_EmployeeEid",
                table: "Skills",
                column: "EmployeeEid",
                principalTable: "Employees",
                principalColumn: "Eid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Departments_DeptidDid",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DeptidDid",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Employees_EmployeeEid",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_EmployeeEid",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DeptidDid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DeptidDid",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmployeeEid",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "DeptidDid",
                table: "Employees",
                newName: "DeptId");

            migrationBuilder.RenameColumn(
                name: "DeptidDid",
                table: "Customers",
                newName: "DeptId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDid",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDid",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_EmployeeId",
                table: "Skills",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDid",
                table: "Employees",
                column: "DepartmentDid");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DepartmentDid",
                table: "Customers",
                column: "DepartmentDid");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Departments_DepartmentDid",
                table: "Customers",
                column: "DepartmentDid",
                principalTable: "Departments",
                principalColumn: "Did",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentDid",
                table: "Employees",
                column: "DepartmentDid",
                principalTable: "Departments",
                principalColumn: "Did",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Employees_EmployeeId",
                table: "Skills",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Eid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
