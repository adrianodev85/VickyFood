using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VickyFood.Migrations
{
    /// <inheritdoc />
    public partial class AddDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName,CategoryActive)" +
                "VALUES('Normal',1)");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName,CategoryActive)" +
                "VALUES('Vegetarian',1)");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName,CategoryActive)" +
                "VALUES('Vegan',1)");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName,CategoryActive)" +
                "VALUES('Drink',1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
