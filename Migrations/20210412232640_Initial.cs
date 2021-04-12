using Microsoft.EntityFrameworkCore.Migrations;

namespace ClosedCircuit.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoundNumber = table.Column<long>(type: "bigint", nullable: false),
                    SmallSpawn = table.Column<int>(type: "int", nullable: false),
                    FastSpawn = table.Column<int>(type: "int", nullable: false),
                    FatSpawn = table.Column<int>(type: "int", nullable: false),
                    BigSpawn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rounds");
        }
    }
}
