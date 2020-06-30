using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordatorioContraseñas.Migrations
{
    public partial class CampoNombre_TablaCuentas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    contrasena = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    activo = table.Column<bool>(nullable: false, defaultValueSql: "('1')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cuentas",
                columns: table => new
                {
                    id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    usuario = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    contrasena = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    fechaModificacion = table.Column<DateTime>(type: "date", nullable: false),
                    usuario_id = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cuentas", x => x.id);
                    table.ForeignKey(
                        name: "FK__cuentaa__usuario__4D94879B",
                        column: x => x.usuario_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cuentas_usuario_id",
                table: "cuentas",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "UQ__usuarios__9AFF8FC625D0757F",
                table: "usuarios",
                column: "usuario",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cuentas");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
