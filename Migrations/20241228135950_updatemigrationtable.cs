using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace denemeodev.Migrations
{
    /// <inheritdoc />
    public partial class updatemigrationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifId", "Adi", "Kapasite" },
                values: new object[,]
                {
                    { 1, "1. Sınıf", 10 },
                    { 2, "2. Sınıf", 10 },
                    { 3, "3. Sınıf", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Siniflar",
                keyColumn: "SinifId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Siniflar",
                keyColumn: "SinifId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Siniflar",
                keyColumn: "SinifId",
                keyValue: 3);
        }
    }
}
