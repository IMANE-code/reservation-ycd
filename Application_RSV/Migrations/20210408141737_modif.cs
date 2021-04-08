using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_RSV.Migrations
{
    public partial class modif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reservations_typeRs_typeidType",
                table: "reservations");

            migrationBuilder.DropIndex(
                name: "IX_reservations_typeidType",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "typeidType",
                table: "reservations");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "reservations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "idstudent",
                table: "reservations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "typeRidType",
                table: "reservations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Count",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_reservations_StudentId",
                table: "reservations",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_typeRidType",
                table: "reservations",
                column: "typeRidType");

            migrationBuilder.AddForeignKey(
                name: "FK_reservations_AspNetUsers_StudentId",
                table: "reservations",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_reservations_typeRs_typeRidType",
                table: "reservations",
                column: "typeRidType",
                principalTable: "typeRs",
                principalColumn: "idType",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reservations_AspNetUsers_StudentId",
                table: "reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_reservations_typeRs_typeRidType",
                table: "reservations");

            migrationBuilder.DropIndex(
                name: "IX_reservations_StudentId",
                table: "reservations");

            migrationBuilder.DropIndex(
                name: "IX_reservations_typeRidType",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "idstudent",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "typeRidType",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "typeidType",
                table: "reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_reservations_typeidType",
                table: "reservations",
                column: "typeidType");

            migrationBuilder.AddForeignKey(
                name: "FK_reservations_typeRs_typeidType",
                table: "reservations",
                column: "typeidType",
                principalTable: "typeRs",
                principalColumn: "idType",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
