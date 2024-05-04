using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Login.API.Migrations
{
    /// <inheritdoc />
    public partial class atualizacao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilialId",
                table: "TB_FUNCIONARIOS",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "empreasaId",
                table: "TB_FUNCIONARIOS",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_nasc",
                table: "TB_CLIENTES",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<int>(
                name: "enderecoId",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TB_EMPRESAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Data_fundacao_empresa = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    isEmpClient = table.Column<bool>(type: "boolean", nullable: false),
                    isAtived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EMPRESAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_ENDERECOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    rua = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_FILIAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false),
                    Data_fundacao_filial = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FILIAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_FILIAS_TB_EMPRESAS_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "TB_EMPRESAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_FILIAS_TB_ENDERECOS_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "TB_ENDERECOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_FILIAS_CLIENTES",
                columns: table => new
                {
                    FiliasId = table.Column<int>(type: "integer", nullable: false),
                    ClientesId = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FILIAS_CLIENTES", x => new { x.ClientesId, x.FiliasId });
                    table.ForeignKey(
                        name: "FK_TB_FILIAS_CLIENTES_TB_CLIENTES_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_FILIAS_CLIENTES_TB_FILIAS_FiliasId",
                        column: x => x.FiliasId,
                        principalTable: "TB_FILIAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIOS_FilialId",
                table: "TB_FUNCIONARIOS",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_enderecoId",
                table: "AspNetUsers",
                column: "enderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FILIAS_EmpresaId",
                table: "TB_FILIAS",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FILIAS_EnderecoId",
                table: "TB_FILIAS",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FILIAS_CLIENTES_FiliasId",
                table: "TB_FILIAS_CLIENTES",
                column: "FiliasId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TB_ENDERECOS_enderecoId",
                table: "AspNetUsers",
                column: "enderecoId",
                principalTable: "TB_ENDERECOS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_FUNCIONARIOS_TB_FILIAS_FilialId",
                table: "TB_FUNCIONARIOS",
                column: "FilialId",
                principalTable: "TB_FILIAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TB_ENDERECOS_enderecoId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_FUNCIONARIOS_TB_FILIAS_FilialId",
                table: "TB_FUNCIONARIOS");

            migrationBuilder.DropTable(
                name: "TB_FILIAS_CLIENTES");

            migrationBuilder.DropTable(
                name: "TB_FILIAS");

            migrationBuilder.DropTable(
                name: "TB_EMPRESAS");

            migrationBuilder.DropTable(
                name: "TB_ENDERECOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_FUNCIONARIOS_FilialId",
                table: "TB_FUNCIONARIOS");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_enderecoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FilialId",
                table: "TB_FUNCIONARIOS");

            migrationBuilder.DropColumn(
                name: "empreasaId",
                table: "TB_FUNCIONARIOS");

            migrationBuilder.DropColumn(
                name: "enderecoId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_nasc",
                table: "TB_CLIENTES",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);
        }
    }
}
