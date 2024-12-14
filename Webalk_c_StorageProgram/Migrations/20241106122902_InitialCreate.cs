using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webalk_c_StorageProgram.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Esemenyek",
                columns: table => new
                {
                    EsemenyId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EsemenyNev = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Datum = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Helyszin = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    Leiras = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esemenyek", x => x.EsemenyId);
                });

            migrationBuilder.CreateTable(
                name: "Felhasznalok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nev = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    SzuletesiHely = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    SzuletesiDatum = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Neme = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TemaSzine = table.Column<string>(type: "NVARCHAR2(7)", maxLength: 7, nullable: false),
                    KedvencTema = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Jelszo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felhasznalok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Esemény_Resztvevok",
                columns: table => new
                {
                    ResztvevoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EsemenyId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FelhasznaloId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esemény_Resztvevok", x => x.ResztvevoId);
                    table.ForeignKey(
                        name: "FK_Esemény_Resztvevok_Esemenyek_EsemenyId",
                        column: x => x.EsemenyId,
                        principalTable: "Esemenyek",
                        principalColumn: "EsemenyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Esemény_Resztvevok_Felhasznalok_FelhasznaloId",
                        column: x => x.FelhasznaloId,
                        principalTable: "Felhasznalok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Raktarak",
                columns: table => new
                {
                    RaktarId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Terulet = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    ArBerles = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    ArVetel = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    RaktarSzam = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Cim = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TulajdonosId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raktarak", x => x.RaktarId);
                    table.ForeignKey(
                        name: "FK_Raktarak_Felhasznalok_TulajdonosId",
                        column: x => x.TulajdonosId,
                        principalTable: "Felhasznalok",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Berles_Vasarlas",
                columns: table => new
                {
                    TranzakcioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    FelhasznaloId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    RaktarId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Tipus = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    KezdesDatum = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    VegDatum = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Ar = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berles_Vasarlas", x => x.TranzakcioId);
                    table.ForeignKey(
                        name: "FK_Berles_Vasarlas_Felhasznalok_FelhasznaloId",
                        column: x => x.FelhasznaloId,
                        principalTable: "Felhasznalok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Berles_Vasarlas_Raktarak_RaktarId",
                        column: x => x.RaktarId,
                        principalTable: "Raktarak",
                        principalColumn: "RaktarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Berles_Vasarlas_FelhasznaloId",
                table: "Berles_Vasarlas",
                column: "FelhasznaloId");

            migrationBuilder.CreateIndex(
                name: "IX_Berles_Vasarlas_RaktarId",
                table: "Berles_Vasarlas",
                column: "RaktarId");

            migrationBuilder.CreateIndex(
                name: "IX_Esemény_Resztvevok_EsemenyId",
                table: "Esemény_Resztvevok",
                column: "EsemenyId");

            migrationBuilder.CreateIndex(
                name: "IX_Esemény_Resztvevok_FelhasznaloId",
                table: "Esemény_Resztvevok",
                column: "FelhasznaloId");

            migrationBuilder.CreateIndex(
                name: "IX_Raktarak_TulajdonosId",
                table: "Raktarak",
                column: "TulajdonosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Berles_Vasarlas");

            migrationBuilder.DropTable(
                name: "Esemény_Resztvevok");

            migrationBuilder.DropTable(
                name: "Raktarak");

            migrationBuilder.DropTable(
                name: "Esemenyek");

            migrationBuilder.DropTable(
                name: "Felhasznalok");
        }
    }
}
