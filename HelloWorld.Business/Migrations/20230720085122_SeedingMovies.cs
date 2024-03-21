using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HelloWorld.Business.Migrations
{
    /// <inheritdoc />
    public partial class SeedingMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Plot", "ReleaseDate", "Seen", "Title" },
                values: new object[,]
                {
                { 2, "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "The Matrix" },
                { 3, "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway.\r\n\r\n", new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Up" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
