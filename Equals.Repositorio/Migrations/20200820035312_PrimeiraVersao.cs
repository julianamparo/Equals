using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Equals.Repositorio.Migrations
{
    public partial class PrimeiraVersao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adquirentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeAdquirente = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adquirentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoArquivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeTipoArquivo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArquivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arquivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeArquivo = table.Column<string>(maxLength: 100, nullable: false),
                    Recepcionado = table.Column<bool>(nullable: false),
                    DataRecepcao = table.Column<DateTime>(nullable: false),
                    TipoArquivoId = table.Column<int>(nullable: false),
                    AdquirenteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arquivos_Adquirentes_AdquirenteId",
                        column: x => x.AdquirenteId,
                        principalTable: "Adquirentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arquivos_TipoArquivos_TipoArquivoId",
                        column: x => x.TipoArquivoId,
                        principalTable: "TipoArquivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FagammonCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoRegistro = table.Column<string>(nullable: false),
                    DataProcessamento = table.Column<DateTime>(nullable: false),
                    Estabelecimento = table.Column<string>(nullable: false),
                    Adquirente = table.Column<string>(nullable: false),
                    Sequencia = table.Column<string>(nullable: false),
                    ArquivoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FagammonCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FagammonCards_Arquivos_ArquivoId",
                        column: x => x.ArquivoId,
                        principalTable: "Arquivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogErros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArquivoId = table.Column<int>(nullable: false),
                    Mensagem = table.Column<string>(nullable: true),
                    DataProcessamento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogErros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogErros_Arquivos_ArquivoId",
                        column: x => x.ArquivoId,
                        principalTable: "Arquivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UflaCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoRegistro = table.Column<string>(nullable: false),
                    Estabelecimento = table.Column<string>(nullable: false),
                    DataProcessamento = table.Column<DateTime>(nullable: false),
                    PeriodoInicial = table.Column<DateTime>(nullable: false),
                    PeriodoFinal = table.Column<DateTime>(nullable: false),
                    Sequencia = table.Column<string>(nullable: false),
                    Adquirente = table.Column<string>(nullable: false),
                    ArquivoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UflaCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UflaCards_Arquivos_ArquivoId",
                        column: x => x.ArquivoId,
                        principalTable: "Arquivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arquivos_AdquirenteId",
                table: "Arquivos",
                column: "AdquirenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Arquivos_TipoArquivoId",
                table: "Arquivos",
                column: "TipoArquivoId");

            migrationBuilder.CreateIndex(
                name: "IX_FagammonCards_ArquivoId",
                table: "FagammonCards",
                column: "ArquivoId");

            migrationBuilder.CreateIndex(
                name: "IX_LogErros_ArquivoId",
                table: "LogErros",
                column: "ArquivoId");

            migrationBuilder.CreateIndex(
                name: "IX_UflaCards_ArquivoId",
                table: "UflaCards",
                column: "ArquivoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FagammonCards");

            migrationBuilder.DropTable(
                name: "LogErros");

            migrationBuilder.DropTable(
                name: "UflaCards");

            migrationBuilder.DropTable(
                name: "Arquivos");

            migrationBuilder.DropTable(
                name: "Adquirentes");

            migrationBuilder.DropTable(
                name: "TipoArquivos");
        }
    }
}
