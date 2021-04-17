using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class locationLengthAsRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "name",
                table: "Location",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "Location",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Location",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "Location",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

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
        }
    }
}
