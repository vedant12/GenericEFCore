using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedbasemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Movies",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Movies",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Genres",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Genres",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Genres",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Biographies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Biographies",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Biographies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Biographies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Biographies",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Actors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Actors",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Actors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Actors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedOn",
                table: "Actors",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CreatedBy", "CreatedOn", "DateOfBirth", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { 0, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9072), new TimeSpan(0, 0, 0, 0, 0)), null, false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9072), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CreatedBy", "CreatedOn", "DateOfBirth", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { 0, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9113), new TimeSpan(0, 0, 0, 0, 0)), null, false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CreatedBy", "CreatedOn", "DateOfBirth", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { 0, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9115), new TimeSpan(0, 0, 0, 0, 0)), null, false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9115), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CreatedBy", "CreatedOn", "DateOfBirth", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { 0, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, 0, 0, 0, 0)), null, false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CreatedBy", "CreatedOn", "DateOfBirth", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { 0, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, 0, 0, 0, 0)), null, false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 0, 0, 0, 0)), false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9268), new TimeSpan(0, 0, 0, 0, 0)), false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9268), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9270), new TimeSpan(0, 0, 0, 0, 0)), false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9270), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 0, 0, 0, 0)), false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9245), new TimeSpan(0, 0, 0, 0, 0)), false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9245), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 0, 0, 0, 0)), false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9251), new TimeSpan(0, 0, 0, 0, 0)), false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9251), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn" },
                values: new object[] { "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9252), new TimeSpan(0, 0, 0, 0, 0)), false, "System", new DateTimeOffset(new DateTime(2023, 9, 9, 18, 13, 12, 521, DateTimeKind.Unspecified).AddTicks(9252), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Biographies");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Biographies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Biographies");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Biographies");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Biographies");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Actors");
        }
    }
}
