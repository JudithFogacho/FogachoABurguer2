using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FogachoABurguer2.Migrations
{
    /// <inheritdoc />
    public partial class SegundoCambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    PromoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPromo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BurguerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.PromoId);
                    table.ForeignKey(
                        name: "FK_Promo_Burguer_BurguerId",
                        column: x => x.BurguerId,
                        principalTable: "Burguer",
                        principalColumn: "BurguerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_BurguerId",
                table: "Promo",
                column: "BurguerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");
        }
    }
}
