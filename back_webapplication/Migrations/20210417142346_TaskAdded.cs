using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class TaskAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("068755ff-b9b8-4de0-836a-2192e2895620"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("0fc2d4bd-5e38-4785-9859-4ac8bfea4e0f"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("26a930c2-d2a8-4ad6-b1d0-466f6cb2fca3"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("340c885a-11f0-4a07-a0c1-ec9bba7a2c77"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("5afd7d34-6843-42c4-af4e-60a460005984"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("85474142-a0eb-4b53-abb2-c31e56268a85"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("bbb51ee5-cbba-4b4e-89ff-f46930744645"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("ccdbd260-2c09-4f99-8a45-17242e73c03c"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("d37d447d-8495-459a-8b93-d1cf4e24c50f"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("dcc5f515-c77f-49dd-a9a5-51f027c29e71"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("fc4d10c3-fe09-442d-99e3-2f33f7f2d409"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("fd47ad0f-a2ec-4716-9df5-897399cf3e18"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "id",
                keyValue: new Guid("e40c22e3-a67e-4636-afaa-2e0d546e4c66"));

            migrationBuilder.CreateTable(
                name: "PMLTask",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    title = table.Column<string>(maxLength: 200, nullable: true),
                    description = table.Column<string>(nullable: true),
                    duedate = table.Column<DateTime>(nullable: false),
                    completed = table.Column<bool>(nullable: false),
                    parent = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMLTask", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { new Guid("e5153a00-2c6e-4153-90f4-932042bc5279"), "13.4050", "52.5200", "Berlin" },
                    { new Guid("a86f4621-9fda-4d22-a1bd-52e44d111017"), "4.9041", "52.3676", "Amsterdam" },
                    { new Guid("26db13b3-1d1b-45d9-95fb-a89c7afd2e9a"), "14.5058", "46.0569", "Ljubljana" },
                    { new Guid("e2654275-0eb4-4c9d-a90e-086ae4e57723"), "20.4489", "44.7866", "Belgrade" },
                    { new Guid("e56d9e05-ced1-4b74-a7e3-d622f0c67c50"), "15.9819", "45.8150", "Zagreb" },
                    { new Guid("d18b3827-0af6-43a4-9a03-66c67b3d29a7"), "18.4131", "43.8563", "Sarajevo" },
                    { new Guid("a5adeca9-dfdc-4c4c-abd6-199e902f0793"), "12.4964", "41.9028", "Rome" },
                    { new Guid("81604445-a7f6-4995-add9-26ef57d672b9"), "2.3522", "48.8566", "Paris" },
                    { new Guid("9aacc937-22d9-4215-9b76-e03d2c5903f8"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("2cb86e63-6be6-4cc8-89c9-856725333e76"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("af7f85b3-a517-4266-ba83-69f6277693fb"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("8f445045-9be0-4029-88fb-1126cbec9c9a"), "18.0686", "59.3293", "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "id", "address", "cityid", "name" },
                values: new object[] { new Guid("307123e9-adf4-45ed-b330-3942b9b10aad"), "Kosove", new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"), "Filan Fisteku" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PMLTask");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("26db13b3-1d1b-45d9-95fb-a89c7afd2e9a"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("2cb86e63-6be6-4cc8-89c9-856725333e76"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("81604445-a7f6-4995-add9-26ef57d672b9"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("8f445045-9be0-4029-88fb-1126cbec9c9a"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("9aacc937-22d9-4215-9b76-e03d2c5903f8"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("a5adeca9-dfdc-4c4c-abd6-199e902f0793"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("a86f4621-9fda-4d22-a1bd-52e44d111017"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("af7f85b3-a517-4266-ba83-69f6277693fb"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("d18b3827-0af6-43a4-9a03-66c67b3d29a7"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("e2654275-0eb4-4c9d-a90e-086ae4e57723"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("e5153a00-2c6e-4153-90f4-932042bc5279"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("e56d9e05-ced1-4b74-a7e3-d622f0c67c50"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "id",
                keyValue: new Guid("307123e9-adf4-45ed-b330-3942b9b10aad"));

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { new Guid("d37d447d-8495-459a-8b93-d1cf4e24c50f"), "13.4050", "52.5200", "Berlin" },
                    { new Guid("340c885a-11f0-4a07-a0c1-ec9bba7a2c77"), "4.9041", "52.3676", "Amsterdam" },
                    { new Guid("fd47ad0f-a2ec-4716-9df5-897399cf3e18"), "14.5058", "46.0569", "Ljubljana" },
                    { new Guid("bbb51ee5-cbba-4b4e-89ff-f46930744645"), "20.4489", "44.7866", "Belgrade" },
                    { new Guid("fc4d10c3-fe09-442d-99e3-2f33f7f2d409"), "15.9819", "45.8150", "Zagreb" },
                    { new Guid("068755ff-b9b8-4de0-836a-2192e2895620"), "18.4131", "43.8563", "Sarajevo" },
                    { new Guid("85474142-a0eb-4b53-abb2-c31e56268a85"), "12.4964", "41.9028", "Rome" },
                    { new Guid("5afd7d34-6843-42c4-af4e-60a460005984"), "2.3522", "48.8566", "Paris" },
                    { new Guid("26a930c2-d2a8-4ad6-b1d0-466f6cb2fca3"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("dcc5f515-c77f-49dd-a9a5-51f027c29e71"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("ccdbd260-2c09-4f99-8a45-17242e73c03c"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("0fc2d4bd-5e38-4785-9859-4ac8bfea4e0f"), "18.0686", "59.3293", "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "id", "address", "cityid", "name" },
                values: new object[] { new Guid("e40c22e3-a67e-4636-afaa-2e0d546e4c66"), "Kosove", new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"), "Filan Fisteku" });
        }
    }
}
