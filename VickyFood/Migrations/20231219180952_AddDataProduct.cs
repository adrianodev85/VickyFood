using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VickyFood.Migrations
{
    /// <inheritdoc />
    public partial class AddDataProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Cheeseburger','Beef Hamburger with Cheese','Delicious beef burger with cheese, pickles and barbecue sauce',12.00,'/img/Item01_Cheeseburger.jpg',null,1,1,1)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Cheese Salad','Beef Hamburger with Cheese and Salad','Delicious beef burger with cheese, tomato, cucumber, lettuce and barbecue sauce',14.00,'/img/Item02_Cheese_Salad.jpg',null,1,0,1)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Grilled Ham Sandwich','Warm bread with Cheese','Warm bread with cheese',8.00,'/img/Item03_GrilledHamSandwich.jpg',null,1,0,1)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Natural Sandwich','Sandwich with Natural Products','Bread with tomato, lettuce, carrot, cucumber and tofu paste',12.00,'/img/Item04_NaturalSandwich.jpg',null,1,0,2)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Vegan Sandwich','Vegan Sandwich free of animal products','Bread, lettuce, tomato, cucumber, white bean paste and olive oil',14.00,'/img/Item05_VeganSandwich.jpg',null,1,0,3)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Normal Pizza','8-slice Pizza','Pizza in the flavors: Pepperoni, Four Cheeses and Chicken with Cheddar',25.00,'/img/Item06_Pizza.jpg',null,1,1,1)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Big Pizza','12-slice Pizza','Pizza in the flavors: Pepperoni, Four Cheeses and Chicken with Cheddar',35.00,'/img/Item06_Pizza.jpg',null,1,0,1)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('French Fries','French Fries with or without sauce','French fries with the option of cheddar sauce(additional 2.00)',10.00,'/img/Item07_FrenchFries.jpg',null,1,1,1)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Milk Shake','Milk Shake in Various Flavors','Milk Shake in chocolate, vanilha, strawberry and dulce de leche',10.00,'/img/Item13_MilkShakes.jpg',null,1,0,4)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Coke - 350ml','Coke in 350ml Can',null,5.00,'/img/Item08_Coke350.jpg',null,1,1,4)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Coke - 600ml','Coke in 600ml Bottle',null,8.00,'/img/Item09_Coke600.jpg',null,1,0,4)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Fanta - 350ml','Orange Fanta in 350ml Can',null,4.00,'/img/Item10_Fanta350.jpg',null,1,0,4)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Fanta - 600ml','Orange Fanta in 600ml Bottle',null,7.00,'/img/Item11_Fanta600.jpg',null,1,0,4)");
            migrationBuilder.Sql("INSERT INTO Products(ProductName,ProductShortDescription,ProductLongDescription,Price,UrlImage,UrlThumbnail,ProductStock,ProductFavorite,CategoryId)" +
                "VALUES('Juices - 500ml','Juices in Various flavors','Flavors: Orange, Swiss Lemon, Pineapple, Strawberry and Grape',10.00,'/img/Item12_Juices.jpg',null,1,0,4)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
