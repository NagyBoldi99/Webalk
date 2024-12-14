using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webalk_c_StorageProgram.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdatedColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Leiras",
                table: "Esemenyek",
                newName: "LEIRAS");

            migrationBuilder.RenameColumn(
                name: "Helyszin",
                table: "Esemenyek",
                newName: "HELYSZIN");

            migrationBuilder.RenameColumn(
                name: "EsemenyNev",
                table: "Esemenyek",
                newName: "ESEMENYNEV");

            migrationBuilder.RenameColumn(
                name: "Datum",
                table: "Esemenyek",
                newName: "DATUM");

            migrationBuilder.RenameColumn(
                name: "EsemenyId",
                table: "Esemenyek",
                newName: "ESEMENYID");

            migrationBuilder.AlterColumn<decimal>(
                name: "ArVetel",
                table: "Raktarak",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ArBerles",
                table: "Raktarak",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Ar",
                table: "Berles_Vasarlas",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LEIRAS",
                table: "Esemenyek",
                newName: "Leiras");

            migrationBuilder.RenameColumn(
                name: "HELYSZIN",
                table: "Esemenyek",
                newName: "Helyszin");

            migrationBuilder.RenameColumn(
                name: "ESEMENYNEV",
                table: "Esemenyek",
                newName: "EsemenyNev");

            migrationBuilder.RenameColumn(
                name: "DATUM",
                table: "Esemenyek",
                newName: "Datum");

            migrationBuilder.RenameColumn(
                name: "ESEMENYID",
                table: "Esemenyek",
                newName: "EsemenyId");

            migrationBuilder.AlterColumn<decimal>(
                name: "ArVetel",
                table: "Raktarak",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ArBerles",
                table: "Raktarak",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Ar",
                table: "Berles_Vasarlas",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");
        }
    }
}
