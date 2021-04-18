using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapplication.Migrations
{
    public partial class VirtualTaskDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PMLTask_PMLTask_parent1",
                table: "PMLTask");

            migrationBuilder.DropIndex(
                name: "IX_PMLTask_parent1",
                table: "PMLTask");

            migrationBuilder.DropColumn(
                name: "parent1",
                table: "PMLTask");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "parent1",
                table: "PMLTask",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PMLTask_parent1",
                table: "PMLTask",
                column: "parent1");

            migrationBuilder.AddForeignKey(
                name: "FK_PMLTask_PMLTask_parent1",
                table: "PMLTask",
                column: "parent1",
                principalTable: "PMLTask",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
