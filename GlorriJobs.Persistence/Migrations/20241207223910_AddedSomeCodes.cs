using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlorriJobs.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedSomeCodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies");

            migrationBuilder.AddColumn<Guid>(
                name: "VacancyId1",
                table: "VacancyDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "Vacancies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<Guid>(
                name: "IndustryId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosterPath",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyDetails_VacancyId1",
                table: "VacancyDetails",
                column: "VacancyId1",
                unique: true,
                filter: "[VacancyId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacancyDetails_Vacancies_VacancyId1",
                table: "VacancyDetails",
                column: "VacancyId1",
                principalTable: "Vacancies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_VacancyDetails_Vacancies_VacancyId1",
                table: "VacancyDetails");

            migrationBuilder.DropIndex(
                name: "IX_VacancyDetails_VacancyId1",
                table: "VacancyDetails");

            migrationBuilder.DropColumn(
                name: "VacancyId1",
                table: "VacancyDetails");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "PosterPath",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Branches");

            migrationBuilder.AlterColumn<Guid>(
                name: "IndustryId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id");
        }
    }
}
