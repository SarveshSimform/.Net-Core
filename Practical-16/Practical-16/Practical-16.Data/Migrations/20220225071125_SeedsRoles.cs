using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practical_16.Web.Data.Migrations
{
    public partial class SeedsRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "094afa8c-69e3-4103-a542-8aee12940f9a", "45df3a06-b04a-42ac-9b73-c978f1f56363", "Administrator", "ADMINISTRATOR" },
                    { "9f074bba-372c-474e-81a2-92e877a73075", "d956b899-7f75-4f4d-bcea-9eef48624751", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfjoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MobileNumber", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b2546a3-3e7a-454e-ac18-52d4cae97b2f", 0, "74257172-afb6-439f-acae-5504e231beb0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin23@gmail.com", true, "Dhruvin", "Jariwala", false, null, null, "ADMIN23@GMAIL.COM", "ADMIN23@GMAIL.COM", "AQAAAAEAACcQAAAAEK26xt2bj0yJu8uDWVrWVY1clojQTtOy5wXDxfMR8e4pYNPp2fLbYsqTfQIJQrzRYw==", null, false, "e232b530-dbf5-456a-8fea-9a02607cdf78", false, "admin23@gmail.com" },
                    { "4b2546a3-3e7a-424e-ac18-52d4cae97b2f", 0, "6322fb3e-b710-48ae-85ce-c1f02a630713", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "system", "user", false, null, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEA9FIIYEdnxGK8bnZM59UF/1R3sD3Pl5rzyvpYbiAHSloh2L4ruj8ffrO+e7HYYe6A==", null, false, "10a11e7b-485f-4ab8-b4df-18144b33e8b2", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "094afa8c-69e3-4103-a542-8aee12940f9a", "5b2546a3-3e7a-454e-ac18-52d4cae97b2f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9f074bba-372c-474e-81a2-92e877a73075", "4b2546a3-3e7a-424e-ac18-52d4cae97b2f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9f074bba-372c-474e-81a2-92e877a73075", "4b2546a3-3e7a-424e-ac18-52d4cae97b2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "094afa8c-69e3-4103-a542-8aee12940f9a", "5b2546a3-3e7a-454e-ac18-52d4cae97b2f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b2546a3-3e7a-424e-ac18-52d4cae97b2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b2546a3-3e7a-454e-ac18-52d4cae97b2f");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
