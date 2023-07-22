using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class HousesPhotoEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("1329d502-8557-461a-8ce9-0ba7b65c54b7"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("3b0abb88-c32f-45bf-b699-2f23248e8e5c"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("8afc25fa-bb69-4a61-a44b-25f55adaad27"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Houses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 22, 18, 3, 15, 160, DateTimeKind.Utc).AddTicks(3428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 21, 23, 2, 11, 500, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("87c5c3a5-6311-42d7-a237-6703fafdd905"), "Boyana Neighbourhood, Sofia, Bulgaria", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 2, "This luxurious house is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", 2000.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Grand House" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("88a43e12-ec5f-477f-93ff-0b5268551a76"), "Near the Sea Garden in Burgas, Bulgaria", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 2, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://media.rightmove.co.uk/61k/60887/129625586/60887_11437_IMG_00_0000.jpeg", 1200.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Family House Comfort" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("b4060e37-d9a6-4ec5-87f6-69f6b08dc1fc"), "North London, UK (near the border)", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 3, "A big house for your whole family. Don't miss to buy a house with three bedrooms.", "https://nt.global.ssl.fastly.net/binaries/content/gallery/website/national/regions/london/places/red-house/library/built-heritage-history-and-collections/north-front-red-house-london-1243706.jpg", 2100.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Big House Marina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("87c5c3a5-6311-42d7-a237-6703fafdd905"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("88a43e12-ec5f-477f-93ff-0b5268551a76"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("b4060e37-d9a6-4ec5-87f6-69f6b08dc1fc"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Houses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 21, 23, 2, 11, 500, DateTimeKind.Utc).AddTicks(7065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 22, 18, 3, 15, 160, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("1329d502-8557-461a-8ce9-0ba7b65c54b7"), "North London, UK (near the border)", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A big house for your whole family. Don't miss to buy a house with three bedrooms.", "https://www.luxury-architecture.net/wpcontent/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 2100.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Big House Marina" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("3b0abb88-c32f-45bf-b699-2f23248e8e5c"), "Near the Sea Garden in Burgas, Bulgaria", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg", 1200.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Family House Comfort" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("8afc25fa-bb69-4a61-a44b-25f55adaad27"), "Boyana Neighbourhood, Sofia, Bulgaria", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This luxurious house is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", 2000.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Grand House" });
        }
    }
}
