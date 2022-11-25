using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicStore.Models.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AlbumType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "LP" },
                    { 2, "EP" },
                    { 3, "Single" },
                    { 4, "Split" },
                    { 5, "Compilation" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "GenreId", "IsActive", "Name" },
                values: new object[] { 1, null, false, "The Beatles" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "class", "Classical" },
                    { "elec", "Electronic" },
                    { "exp", "Experimental" },
                    { "indie", "Independent" },
                    { "metal", "Metal" },
                    { "rap", "Hip Hop" },
                    { "rock", "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumTypeId", "GenreId", "ImageData", "ImageType", "Price", "Title", "Year" },
                values: new object[] { 1, 1, "rock", null, null, 8.99m, "Revolver", 1966 });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "ArtistId", "DurationInSeconds", "Title", "TrackNumber" },
                values: new object[,]
                {
                    { 1, 1, 1, 159, "Taxman", 1 },
                    { 2, 1, 1, 129, "Eleanor Rigby", 2 },
                    { 3, 1, 1, 182, "I'm Only Sleeping", 3 },
                    { 4, 1, 1, 187, "Love You To", 4 },
                    { 5, 1, 1, 146, "Here, There And Everywhere", 5 },
                    { 6, 1, 1, 160, "Yellow Submarine", 6 },
                    { 7, 1, 1, 159, "She Said She Said", 7 },
                    { 8, 1, 1, 130, "Good Day Sunshine", 8 },
                    { 9, 1, 1, 123, "And Your Bird Can Sing", 9 },
                    { 10, 1, 1, 122, "For No One", 10 },
                    { 11, 1, 1, 137, "Doctor Robert", 11 },
                    { 12, 1, 1, 152, "I Want To Tell You", 12 },
                    { 13, 1, 1, 157, "Got to Get You Into My Life", 13 },
                    { 14, 1, 1, 177, "Tomorrow Never Knows", 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AlbumType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AlbumType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AlbumType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "class");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "elec");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "exp");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "indie");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "metal");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "rap");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AlbumType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "rock");
        }
    }
}
