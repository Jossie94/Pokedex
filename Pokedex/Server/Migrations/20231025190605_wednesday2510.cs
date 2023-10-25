using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Server.Migrations
{
    /// <inheritdoc />
    public partial class wednesday2510 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonTrainers",
                columns: table => new
                {
                    Tid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTrainers", x => x.Tid);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    pId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    abilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pokepic = table.Column<byte[]>(type: "varbinary(max)", maxLength: 1048576, nullable: false),
                    PokemontrainerTid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.pId);
                    table.ForeignKey(
                        name: "FK_Pokemons_PokemonTrainers_PokemontrainerTid",
                        column: x => x.PokemontrainerTid,
                        principalTable: "PokemonTrainers",
                        principalColumn: "Tid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemontrainerTid",
                table: "Pokemons",
                column: "PokemontrainerTid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "PokemonTrainers");
        }
    }
}
