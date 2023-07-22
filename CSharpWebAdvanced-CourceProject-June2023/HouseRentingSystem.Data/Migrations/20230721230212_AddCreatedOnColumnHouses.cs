using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class AddCreatedOnColumnHouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("5d07344f-9fc6-44f7-beee-5b1f8bddfcca"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("7ac3cab2-ae8b-4437-a09e-5c89f4edbe57"));

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("ed81842f-0b2e-4342-a3b7-df12360a6d33"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Houses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 21, 23, 2, 11, 500, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("1329d502-8557-461a-8ce9-0ba7b65c54b7"), "North London, UK (near the border)", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 3, "A big house for your whole family. Don't miss to buy a house with three bedrooms.", "https://www.luxury-architecture.net/wpcontent/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 2100.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Big House Marina" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("3b0abb88-c32f-45bf-b699-2f23248e8e5c"), "Near the Sea Garden in Burgas, Bulgaria", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 2, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg", 1200.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Family House Comfort" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("8afc25fa-bb69-4a61-a44b-25f55adaad27"), "Boyana Neighbourhood, Sofia, Bulgaria", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 2, "This luxurious house is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", 2000.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Grand House" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Houses");

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("5d07344f-9fc6-44f7-beee-5b1f8bddfcca"), "Boyana Neighbourhood, Sofia, Bulgaria", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 2, "This luxurious house is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", 2000.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Grand House" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("7ac3cab2-ae8b-4437-a09e-5c89f4edbe57"), "Near the Sea Garden in Burgas, Bulgaria", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 2, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg", 1200.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Family House Comfort" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("ed81842f-0b2e-4342-a3b7-df12360a6d33"), "North London, UK (near the border)", new Guid("5268e332-c6b6-43de-ba7c-7484f968037a"), 3, "A big house for your whole family. Don't miss to buy a house with three bedrooms.", "https://www.luxury-architecture.net/wpcontent/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 2100.00m, new Guid("2d21dcfb-0211-4ab6-bd2e-08db8a01096f"), "Big House Marina" });
        }
    }
}
