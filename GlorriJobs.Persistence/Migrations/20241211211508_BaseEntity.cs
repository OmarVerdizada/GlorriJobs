using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlorriJobs.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VacancyDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "VacancyDetails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Biographies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Biographies");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "VacancyDetails",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Vacancies",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Industries",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Departments",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "CompanyDetails",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Companies",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Cities",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Categories",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Branches",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Biographies",
                newName: "ModifiedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "VacancyDetails",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Vacancies",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Industries",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Departments",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "CompanyDetails",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Companies",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Cities",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Categories",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Branches",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Biographies",
                newName: "UpdatedDate");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "VacancyDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "VacancyDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Vacancies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Vacancies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CompanyDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CompanyDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Biographies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Biographies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
