using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace denemeodev.Migrations
{
    /// <inheritdoc />
    public partial class updatemigrationtableders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersId", "Baslik" },
                values: new object[,]
                {
                    { 1, "İnternet Programcılığı" },
                    { 2, "Görsel Programlama" },
                    { 3, "Nesne Programlama" },
                    { 4, "İş Sağlığı ve Güvenliği" },
                    { 5, "Veri Tabanı" },
                    { 6, "Yapay Zeka" },
                    { 7, "Adli Bilişim" },
                    { 8, "Zaman Yönetimi" },
                    { 9, "ERP" },
                    { 10, "Donanım" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 10);
        }
    }
}
