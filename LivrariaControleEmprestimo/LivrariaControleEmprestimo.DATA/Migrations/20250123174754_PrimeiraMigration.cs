using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cpf = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    autor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Livro_Cliente_Emprestimo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataEmprestimo = table.Column<DateTime>(type: "datetime", nullable: false),
                    dataDevolucao = table.Column<DateTime>(type: "datetime", nullable: false),
                    idLivro = table.Column<int>(type: "int", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro_Cliente_Emprestimo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Livro_Cliente_Emprestimo_Cliente",
                        column: x => x.idCliente,
                        principalTable: "Cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Livro_Cliente_Emprestimo_Livro",
                        column: x => x.idLivro,
                        principalTable: "Livro",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Cliente_Emprestimo_idCliente",
                table: "Livro_Cliente_Emprestimo",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Cliente_Emprestimo_idLivro",
                table: "Livro_Cliente_Emprestimo",
                column: "idLivro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro_Cliente_Emprestimo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Livro");
        }
    }
}
