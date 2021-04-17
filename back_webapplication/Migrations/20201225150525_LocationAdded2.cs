using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class LocationAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: true),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    cityid = table.Column<Guid>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.id);
                    table.ForeignKey(
                        name: "FK_Location_City_cityid",
                        column: x => x.cityid,
                        principalTable: "City",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Location_cityid",
                table: "Location",
                column: "cityid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Location");

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
                    { new Guid("50c9fcb1-1cca-49bd-9e68-f47dfa177956"), "12.4964", "41.9028", "Rome" },
                    { new Guid("e77ac9f6-5dc7-4ae3-82b1-6174881ba904"), "2.3522", "48.8566", "Paris" },
                    { new Guid("50cc0d1e-e2a1-4e5a-b714-25f71f7dd838"), "3.7038", "40.4168", "Madrid" },
                    { new Guid("a09c4620-f8f6-46dc-8b4c-3b20ff6e2044"), "28.9784", "41.0082", "Istanbul" },
                    { new Guid("4db77daf-6e78-4981-ade0-36c11440b987"), "37.6173", "55.7558", "Moscow" },
                    { new Guid("89ee4f8c-c988-4267-aada-ecfd509271a7"), "18.0686", "59.3293", "Stockholm" }
                });
        }
    }
}
