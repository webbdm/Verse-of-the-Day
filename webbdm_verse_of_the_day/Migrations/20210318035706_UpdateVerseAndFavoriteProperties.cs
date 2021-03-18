using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webbdm_verse_of_the_day.Migrations
{
    public partial class UpdateVerseAndFavoriteProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Verses",
                newName: "IsValid");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Verses",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "BibleReferenceLink",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookShareUrl",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasBeenFavorited",
                table: "Verses",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImageLink",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PinterestShareUrl",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferenceLink",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferenceText",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterShareUrl",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VerseDate",
                table: "Verses",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "VerseNumbers",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerseText",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoLink",
                table: "Verses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VerseId",
                table: "Favorites",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BibleReferenceLink",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "FacebookShareUrl",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "HasBeenFavorited",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "ImageLink",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "PinterestShareUrl",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "ReferenceLink",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "ReferenceText",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "TwitterShareUrl",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "VerseDate",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "VerseNumbers",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "VerseText",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "VideoLink",
                table: "Verses");

            migrationBuilder.RenameColumn(
                name: "IsValid",
                table: "Verses",
                newName: "Text");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Verses",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "VerseId",
                table: "Favorites",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
