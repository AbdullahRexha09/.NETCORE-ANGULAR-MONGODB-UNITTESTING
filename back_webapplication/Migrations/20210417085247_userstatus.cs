using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class userstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("4657360b-58e5-49a1-9b4a-06b31e53d606"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("533327df-57c1-4331-8d2c-3cade269b844"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("60ee2fb6-87e1-4c92-989d-daec80f69a36"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("63832e19-8813-4a3d-aee7-d6922aeb7114"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("72b3f97c-77dd-4bbf-b78f-82313435990b"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("7923456f-b655-44e4-a33a-2578f2d66b29"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("91f6f7bd-890d-48b0-a63a-ee5b6a01e24f"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("a0b8211e-c795-4a2f-b03a-d1e89e786f81"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("ba86f140-d341-4193-897b-5467f1432d6b"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("bd057f1b-855c-461a-aec0-576eda457be2"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("ca32700a-60af-452e-818c-006ffa11d291"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("eadb8d26-393a-4e61-9920-c0bf12f429bd"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "id",
                keyValue: new Guid("98863cfb-e0db-4da6-8520-b6f4e1756395"));

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "User",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "status",
                table: "User");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { new Guid("4657360b-58e5-49a1-9b4a-06b31e53d606"), "13.4050", "52.5200", "Berlin" },
                    { new Guid("ba86f140-d341-4193-897b-5467f1432d6b"), "4.9041", "52.3676", "Amsterdam" },
                    { new Guid("7923456f-b655-44e4-a33a-2578f2d66b29"), "14.5058", "46.0569", "Ljubljana" },
                    { new Guid("72b3f97c-77dd-4bbf-b78f-82313435990b"), "20.4489", "44.7866", "Belgrade" },
                    { new Guid("63832e19-8813-4a3d-aee7-d6922aeb7114"), "15.9819", "45.8150", "Zagreb" },
                    { new Guid("eadb8d26-393a-4e61-9920-c0bf12f429bd"), "18.4131", "43.8563", "Sarajevo" },
                    { new Guid("533327df-57c1-4331-8d2c-3cade269b844"), "12.4964", "41.9028", "Rome" },
                    { new Guid("a0b8211e-c795-4a2f-b03a-d1e89e786f81"), "2.3522", "48.8566", "Paris" },
                    { new Guid("60ee2fb6-87e1-4c92-989d-daec80f69a36"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("bd057f1b-855c-461a-aec0-576eda457be2"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("ca32700a-60af-452e-818c-006ffa11d291"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("91f6f7bd-890d-48b0-a63a-ee5b6a01e24f"), "18.0686", "59.3293", "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "id", "address", "cityid", "name" },
                values: new object[] { new Guid("98863cfb-e0db-4da6-8520-b6f4e1756395"), "Kosove", new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"), "Filan Fisteku" });
        }
    }
}
