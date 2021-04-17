using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class emailIsUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("0eac29f7-7649-4b81-ab72-b2e35c1e9542"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("13ed15d4-263c-47e8-a31c-11cb095aace1"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("38f5a480-7a02-40a5-827c-7589f191d92e"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("470e2e5c-2e49-46d9-bb5e-0d33482d34be"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("75e03fa7-41f9-4748-a31d-0ce87bb380b1"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("7a553363-c6f1-453c-b78a-9d8c84788597"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("89a81304-9643-4813-bc13-060cd978c56f"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("8a9be924-2356-4980-a381-e40933bb0ba2"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("ab33302d-e32e-490c-bf5c-4d440a57f30a"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("b9f4bb18-de16-477f-9ce9-cd93c9c1642d"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("bdde8166-e8b6-44a2-ac84-3ac5da58497c"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("f3b0c5c0-af77-48fe-9307-d7feb7c00c86"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "id",
                keyValue: new Guid("84d3b430-8c57-40da-afc4-6315e5c8b9a7"));

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { new Guid("b44062bd-9f2d-49dc-8dae-fc1059cf6837"), "13.4050", "52.5200", "Berlin" },
                    { new Guid("ce9736ec-9a31-4796-bda4-2113874815c1"), "4.9041", "52.3676", "Amsterdam" },
                    { new Guid("6f34f714-098f-4a65-bcf9-800919cab23e"), "14.5058", "46.0569", "Ljubljana" },
                    { new Guid("54e486dc-80e8-498d-a407-6edae2475b5d"), "20.4489", "44.7866", "Belgrade" },
                    { new Guid("af50ce58-559a-4be5-bb84-225fd67b2a96"), "15.9819", "45.8150", "Zagreb" },
                    { new Guid("56e827e9-a3c7-49ac-88fb-122addf14b1d"), "18.4131", "43.8563", "Sarajevo" },
                    { new Guid("6a3ee7fc-0460-4fb9-a21d-416cd9ea1590"), "12.4964", "41.9028", "Rome" },
                    { new Guid("adcfec71-0fb1-4397-8ca6-376b7b262c9a"), "2.3522", "48.8566", "Paris" },
                    { new Guid("e6be14e6-f54c-492f-9899-be29015b6642"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("5f3ab6cd-0d03-4380-86f0-b8d87b7da596"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("293c144a-d080-4aec-9e5c-cdd9d19021fd"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("c9d721a5-77b5-468b-b076-d5170c322910"), "18.0686", "59.3293", "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "id", "address", "cityid", "name" },
                values: new object[] { new Guid("ec6e38a2-97a8-44db-be27-640906e0ca32"), "Kosove", new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"), "Filan Fisteku" });

            migrationBuilder.CreateIndex(
                name: "IX_User_email",
                table: "User",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_email",
                table: "User");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("293c144a-d080-4aec-9e5c-cdd9d19021fd"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("54e486dc-80e8-498d-a407-6edae2475b5d"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("56e827e9-a3c7-49ac-88fb-122addf14b1d"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("5f3ab6cd-0d03-4380-86f0-b8d87b7da596"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("6a3ee7fc-0460-4fb9-a21d-416cd9ea1590"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("6f34f714-098f-4a65-bcf9-800919cab23e"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("adcfec71-0fb1-4397-8ca6-376b7b262c9a"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("af50ce58-559a-4be5-bb84-225fd67b2a96"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("b44062bd-9f2d-49dc-8dae-fc1059cf6837"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("c9d721a5-77b5-468b-b076-d5170c322910"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("ce9736ec-9a31-4796-bda4-2113874815c1"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("e6be14e6-f54c-492f-9899-be29015b6642"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "id",
                keyValue: new Guid("ec6e38a2-97a8-44db-be27-640906e0ca32"));

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { new Guid("38f5a480-7a02-40a5-827c-7589f191d92e"), "13.4050", "52.5200", "Berlin" },
                    { new Guid("b9f4bb18-de16-477f-9ce9-cd93c9c1642d"), "4.9041", "52.3676", "Amsterdam" },
                    { new Guid("75e03fa7-41f9-4748-a31d-0ce87bb380b1"), "14.5058", "46.0569", "Ljubljana" },
                    { new Guid("bdde8166-e8b6-44a2-ac84-3ac5da58497c"), "20.4489", "44.7866", "Belgrade" },
                    { new Guid("89a81304-9643-4813-bc13-060cd978c56f"), "15.9819", "45.8150", "Zagreb" },
                    { new Guid("8a9be924-2356-4980-a381-e40933bb0ba2"), "18.4131", "43.8563", "Sarajevo" },
                    { new Guid("13ed15d4-263c-47e8-a31c-11cb095aace1"), "12.4964", "41.9028", "Rome" },
                    { new Guid("470e2e5c-2e49-46d9-bb5e-0d33482d34be"), "2.3522", "48.8566", "Paris" },
                    { new Guid("ab33302d-e32e-490c-bf5c-4d440a57f30a"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("f3b0c5c0-af77-48fe-9307-d7feb7c00c86"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("0eac29f7-7649-4b81-ab72-b2e35c1e9542"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("7a553363-c6f1-453c-b78a-9d8c84788597"), "18.0686", "59.3293", "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "id", "address", "cityid", "name" },
                values: new object[] { new Guid("84d3b430-8c57-40da-afc4-6315e5c8b9a7"), "Kosove", new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"), "Filan Fisteku" });
        }
    }
}
