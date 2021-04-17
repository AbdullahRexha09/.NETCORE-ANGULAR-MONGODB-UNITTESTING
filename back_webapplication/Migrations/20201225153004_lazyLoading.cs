using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class lazyLoading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("050682a4-32d4-451a-aa9f-2a037c6e0368"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("1972dc17-d28c-4e94-b2e0-bc285a82c1af"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("5b0ed914-54bc-4675-a75a-3c25fdff6138"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("61fee9ca-fb43-4faa-bdab-ccfe330a2e61"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("68bc7b6a-dfdb-41b8-85b9-4c712c7fd767"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("aa92c52d-1a64-48f4-a9b5-84b5ee0133a8"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("b11bb54b-4298-41e8-95d6-1b4dbb6cbd8c"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("b2e69673-7427-427e-a32a-49f9efae0a08"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("dcd792cb-1d7f-425d-90e8-92fc800c735b"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("ecd3a7aa-2cb5-4476-96a0-b30c833734e4"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("f41a0aa8-f4f6-4864-9688-9d608fb51fbb"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: new Guid("fe2baf00-c52a-4294-a1fd-dc6c6b2d486e"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "id",
                keyValue: new Guid("52aba146-8690-41c7-81c4-ff63672819b3"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { new Guid("f41a0aa8-f4f6-4864-9688-9d608fb51fbb"), "13.4050", "52.5200", "Berlin" },
                    { new Guid("fe2baf00-c52a-4294-a1fd-dc6c6b2d486e"), "4.9041", "52.3676", "Amsterdam" },
                    { new Guid("1972dc17-d28c-4e94-b2e0-bc285a82c1af"), "14.5058", "46.0569", "Ljubljana" },
                    { new Guid("b11bb54b-4298-41e8-95d6-1b4dbb6cbd8c"), "20.4489", "44.7866", "Belgrade" },
                    { new Guid("68bc7b6a-dfdb-41b8-85b9-4c712c7fd767"), "15.9819", "45.8150", "Zagreb" },
                    { new Guid("dcd792cb-1d7f-425d-90e8-92fc800c735b"), "18.4131", "43.8563", "Sarajevo" },
                    { new Guid("050682a4-32d4-451a-aa9f-2a037c6e0368"), "12.4964", "41.9028", "Rome" },
                    { new Guid("61fee9ca-fb43-4faa-bdab-ccfe330a2e61"), "2.3522", "48.8566", "Paris" },
                    { new Guid("ecd3a7aa-2cb5-4476-96a0-b30c833734e4"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("b2e69673-7427-427e-a32a-49f9efae0a08"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("5b0ed914-54bc-4675-a75a-3c25fdff6138"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("aa92c52d-1a64-48f4-a9b5-84b5ee0133a8"), "18.0686", "59.3293", "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "id", "address", "cityid", "name" },
                values: new object[] { new Guid("52aba146-8690-41c7-81c4-ff63672819b3"), "Kosove", new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"), "Filan Fisteku" });
        }
    }
}
