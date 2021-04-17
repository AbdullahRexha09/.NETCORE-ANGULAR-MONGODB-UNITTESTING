using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class Cities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: true),
                    longitude = table.Column<string>(maxLength: 10, nullable: true),
                    latitude = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
