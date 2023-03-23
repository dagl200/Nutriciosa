using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp___Angular_2.Migrations
{
    /// <inheritdoc />
    public partial class removeForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Num_telefonos_TelefonoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_TelefonoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "TelefonoId",
                table: "Empleados");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Empleados",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "TelefonoId",
                table: "Empleados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_TelefonoId",
                table: "Empleados",
                column: "TelefonoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Num_telefonos_TelefonoId",
                table: "Empleados",
                column: "TelefonoId",
                principalTable: "Num_telefonos",
                principalColumn: "TelefonoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
