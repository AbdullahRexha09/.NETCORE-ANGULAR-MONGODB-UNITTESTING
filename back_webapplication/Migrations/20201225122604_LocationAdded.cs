using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class LocationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("07d5c60f-8feb-4900-b5c2-fb4ca1166da0"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("15ba183e-988d-482a-847b-1cc806b5f94d"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("414d96cc-d30a-4371-824c-3b6175c8694f"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("469c217f-8b98-4bab-80d6-d490368d5c6d"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("54fcd149-d972-4f24-baff-bcc588b2d9e7"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("6b32e63d-5513-4bfc-a228-3d1151721535"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("7cb66935-1eea-4784-93a9-a7f39c3eb5e1"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("85f9140a-fe91-48f9-9dee-7b3f3ff08f4f"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("8f5fce42-92e6-4f35-9b11-f6a2435d4502"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("a197d778-878a-410c-aef3-6b769342ee51"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("c314fc04-36df-4eef-91a8-a28fcf5b5c21"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("d130759a-24a1-49bc-84ce-0a91fdc5d69d"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("f4b66416-2350-448c-9612-693232313723"));

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { new Guid("7ddf494c-3663-4722-9212-0954eb88c0fc"), "13.4050", "52.5200", "Berlin" },
                    { new Guid("0f9768f1-b4de-400c-8893-1e3179ff2f88"), "4.9041", "52.3676", "Amsterdam" },
                    { new Guid("b8c8bf3c-67e2-44ca-a244-5e2f62f701dd"), "14.5058", "46.0569", "Ljubljana" },
                    { new Guid("30cfd739-0740-4e5b-94a7-d20a0b295b9f"), "20.4489", "44.7866", "Belgrade" },
                    { new Guid("0d6bd147-b508-4279-a683-3f8b76ccbc17"), "15.9819", "45.8150", "Zagreb" },
                    { new Guid("d055ef84-13e1-4beb-8a11-ae6da2de93b7"), "18.4131", "43.8563", "Sarajevo" },
                    { new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"), "21.1655", "42.6629", "Prishtina" },
                    { new Guid("50c9fcb1-1cca-49bd-9e68-f47dfa177956"), "12.4964", "41.9028", "Rome" },
                    { new Guid("e77ac9f6-5dc7-4ae3-82b1-6174881ba904"), "2.3522", "48.8566", "Paris" },
                    { new Guid("50cc0d1e-e2a1-4e5a-b714-25f71f7dd838"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("a09c4620-f8f6-46dc-8b4c-3b20ff6e2044"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("4db77daf-6e78-4981-ade0-36c11440b987"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("89ee4f8c-c988-4267-aada-ecfd509271a7"), "18.0686", "59.3293", "Stockholm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("0d6bd147-b508-4279-a683-3f8b76ccbc17"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("0f9768f1-b4de-400c-8893-1e3179ff2f88"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("30cfd739-0740-4e5b-94a7-d20a0b295b9f"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("4db77daf-6e78-4981-ade0-36c11440b987"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("50c9fcb1-1cca-49bd-9e68-f47dfa177956"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("50cc0d1e-e2a1-4e5a-b714-25f71f7dd838"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("7ddf494c-3663-4722-9212-0954eb88c0fc"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("89ee4f8c-c988-4267-aada-ecfd509271a7"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("a09c4620-f8f6-46dc-8b4c-3b20ff6e2044"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("b8c8bf3c-67e2-44ca-a244-5e2f62f701dd"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("d055ef84-13e1-4beb-8a11-ae6da2de93b7"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("e77ac9f6-5dc7-4ae3-82b1-6174881ba904"));

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { new Guid("f4b66416-2350-448c-9612-693232313723"), "13.4050", "52.5200", "Berlin" },
                    { new Guid("85f9140a-fe91-48f9-9dee-7b3f3ff08f4f"), "4.9041", "52.3676", "Amsterdam" },
                    { new Guid("8f5fce42-92e6-4f35-9b11-f6a2435d4502"), "14.5058", "46.0569", "Ljubljana" },
                    { new Guid("c314fc04-36df-4eef-91a8-a28fcf5b5c21"), "20.4489", "44.7866", "Belgrade" },
                    { new Guid("a197d778-878a-410c-aef3-6b769342ee51"), "15.9819", "45.8150", "Zagreb" },
                    { new Guid("414d96cc-d30a-4371-824c-3b6175c8694f"), "18.4131", "43.8563", "Sarajevo" },
                    { new Guid("6b32e63d-5513-4bfc-a228-3d1151721535"), "21.1655", "42.6629", "Prishtina" },
                    { new Guid("54fcd149-d972-4f24-baff-bcc588b2d9e7"), "12.4964", "41.9028", "Rome" },
                    { new Guid("469c217f-8b98-4bab-80d6-d490368d5c6d"), "2.3522", "48.8566", "Paris" },
                    { new Guid("15ba183e-988d-482a-847b-1cc806b5f94d"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("d130759a-24a1-49bc-84ce-0a91fdc5d69d"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("07d5c60f-8feb-4900-b5c2-fb4ca1166da0"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("7cb66935-1eea-4784-93a9-a7f39c3eb5e1"), "18.0686", "59.3293", "Stockholm" }
                });
        }
    }
}
