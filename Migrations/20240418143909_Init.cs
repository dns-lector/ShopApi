using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceCent = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Декоративні та сувенірні товари зі скла", "glass.jpg", true, "Вироби зі скла", "glass" },
                    { new Guid("62bab42b-3652-42f6-b3c1-221ce296d66d"), "Декоративні та сувенірні товари з каменю", "stone.jpg", true, "Вироби з каменю", "stone" },
                    { new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"), "Сувенірні товари для встановлення на стіл", "office.jpg", true, "Товари для офісу", "office" },
                    { new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"), "Практичні та декоративні товари з деревини", "wood.jpg", true, "Вироби з деревини", "wood" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "IsActive", "Name", "PriceCent", "Slug" },
                values: new object[,]
                {
                    { new Guid("0df61203-45d5-47e6-acad-0eef86f3757a"), new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Фігурка павича з кольорового скла", "glass6.jpg", true, "Пава", 19000, "glass6" },
                    { new Guid("35755354-fda6-4cba-b39d-d657067c6b39"), new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"), "Декоративний твір з дерева", "wood5.jpeg", true, "Леви", 54000, "wood5" },
                    { new Guid("3d149a4c-cf4c-403a-b524-e107f684bbae"), new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"), "Декоративний настільний маятник Ньютона", "office2.jpg", true, "Маятник Ньютона", 42000, "office2" },
                    { new Guid("5fd8b900-ebff-4a0b-a782-a25827555046"), new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"), "Декоративний настільний маятник у формі орбітальних кульок", "office7.jpg", true, "Маятник", 35000, "office7" },
                    { new Guid("6f6a5542-41dd-4aff-ab50-9ee37b59c8aa"), new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"), "Набір кухолів з дерева", "wood3.jpg", true, "Кухолі", 21000, "wood3" },
                    { new Guid("7cadc8af-3b7d-449f-a003-c99658fb693b"), new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Скляна настільна форма для цукерок", "glass5.jpg", true, "Цукерниця", 37000, "glass5" },
                    { new Guid("87972425-8713-4f0c-85e5-536ba16eee4f"), new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Декоративна скляна сфера з терезами", "glass8.jpg", true, "Ваги", 34000, "glass8" },
                    { new Guid("87b48b86-6347-4a12-8f7d-31d89fc2f793"), new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"), "Прес для паперів у формі штурвалу", "office5.jpeg", true, "Штурвал", 34550, "office5" },
                    { new Guid("8831cc8b-2ef1-402d-a2d3-00ab4fa11cc8"), new Guid("62bab42b-3652-42f6-b3c1-221ce296d66d"), "Фігурка-амулет у формі сови", "stone3.jpg", true, "Сова", 30000, "stone3" },
                    { new Guid("ab475e6d-3c31-40bc-bede-01c9950fb597"), new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"), "Декоративний настільний маятник у формі планетарної системи", "office6.jpg", true, "Система", 32500, "office6" },
                    { new Guid("b1659daa-ed1a-4937-b795-12d03f755520"), new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"), "Декоративний настільний маятник у формі Жордана", "office4.jpg", true, "Маятник Жордана", 37500, "office4" },
                    { new Guid("b466382a-a59b-471a-a847-4a53b582da09"), new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"), "Декоративна настільна фігурка", "office3.jpg", true, "Сонцеворот", 33000, "office3" },
                    { new Guid("b574fa3b-3053-4a7f-974f-1ec777a8d4fd"), new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"), "Кошик з дерева середнього розміру", "wood1.jpg", true, "Кошик", 48000, "wood1" },
                    { new Guid("bef5a5dc-8bbb-485b-adcf-dcf9b7f62e72"), new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Декоративна скляна сфера з ялинкою", "glass1.png", true, "Сфера з ялинкою", 32050, "glass1" },
                    { new Guid("c6759bfd-8463-4601-aaea-3f4902402dbd"), new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Фігурка бика з кольорового скла", "glass2.jpg", true, "Бик", 41000, "glass2" },
                    { new Guid("c7226697-c40c-41ed-8a6e-0acab3637691"), new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"), "Сувенір - булава з дерева", "wood2.jpg", true, "Булава", 85000, "wood2" },
                    { new Guid("cb54c85d-a9cd-4068-8bba-234af7f8107d"), new Guid("fd7cc5c1-3543-4bd6-b36c-64cf7e8f9030"), "Настільна підставка для олівців з черепахою", "wood4.jpg", true, "Черепаха", 42050, "wood4" },
                    { new Guid("d31b9563-1292-483a-89ca-ae0caa50a244"), new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Фігурка кота з прозорого скла", "glass7.jpg", true, "Кіт", 41050, "glass7" },
                    { new Guid("d714a1c5-3586-4c3b-9b77-d450813c6816"), new Guid("62bab42b-3652-42f6-b3c1-221ce296d66d"), "Посуд-цукорниця з природнього каменю", "stone1.jpg", true, "Цукорниця", 35000, "stone1" },
                    { new Guid("e362e363-205d-439e-9778-2b504c34e9a3"), new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Декоративна скляна сфера з гелікоптером", "glass3.jpg", true, "Гелікоптер", 33050, "glass3" },
                    { new Guid("eead4f41-cd3f-44ca-83d7-68b79d80e880"), new Guid("25044c03-549f-4a52-86c3-975196966aa1"), "Фігурка лисиці з кольорового скла", "glass4.jpeg", true, "Лис", 25000, "glass4" },
                    { new Guid("fbafcf92-f5ed-4576-815a-293dfc15af61"), new Guid("62bab42b-3652-42f6-b3c1-221ce296d66d"), "Декоративна фігурка у формі груши з природнього каменю", "stone2.jpg", true, "Груша", 40000, "stone2" },
                    { new Guid("fe434459-bb36-4a09-9494-395504531286"), new Guid("d6b69746-b24c-4f42-927b-78c1d539af38"), "Декоративний настільний маятник у формі вершника", "office1.jpeg", true, "Вершник", 39050, "office1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Slug",
                table: "Categories",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Slug",
                table: "Products",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
