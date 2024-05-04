using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Login.API.Migrations
{
    /// <inheritdoc />
    public partial class atualizacao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "created",
                table: "TB_FUNCIONARIOS",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "created",
                table: "TB_CLIENTES",
                newName: "Created");

            migrationBuilder.AddColumn<bool>(
                name: "isAtived",
                table: "TB_FUNCIONARIOS",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isAtived",
                table: "TB_CLIENTES",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAtived",
                table: "TB_FUNCIONARIOS");

            migrationBuilder.DropColumn(
                name: "isAtived",
                table: "TB_CLIENTES");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "TB_FUNCIONARIOS",
                newName: "created");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "TB_CLIENTES",
                newName: "created");
        }
    }
}
