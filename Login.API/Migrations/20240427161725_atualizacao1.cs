using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Login.API.Migrations
{
    /// <inheritdoc />
    public partial class atualizacao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_AspNetUsers_UserId",
                table: "clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "clientes");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "TB_CLIENTES");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_UserId",
                table: "TB_CLIENTES",
                newName: "IX_TB_CLIENTES_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TB_CLIENTES",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_CLIENTES",
                table: "TB_CLIENTES",
                column: "id");

            migrationBuilder.CreateTable(
                name: "TB_FUNCIONARIOS",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Data_nasc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCIONARIOS", x => x.id);
                    table.ForeignKey(
                        name: "FK_TB_FUNCIONARIOS_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIOS_UserId",
                table: "TB_FUNCIONARIOS",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CLIENTES_AspNetUsers_UserId",
                table: "TB_CLIENTES",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CLIENTES_AspNetUsers_UserId",
                table: "TB_CLIENTES");

            migrationBuilder.DropTable(
                name: "TB_FUNCIONARIOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_CLIENTES",
                table: "TB_CLIENTES");

            migrationBuilder.RenameTable(
                name: "TB_CLIENTES",
                newName: "clientes");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CLIENTES_UserId",
                table: "clientes",
                newName: "IX_clientes_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "clientes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "clientes",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_AspNetUsers_UserId",
                table: "clientes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
