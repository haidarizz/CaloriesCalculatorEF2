using Microsoft.EntityFrameworkCore.Migrations;

namespace CaloriesCalculatorEF2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodies",
                columns: table => new
                {
                    BodyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodies", x => x.BodyID);
                });

            migrationBuilder.CreateTable(
                name: "Generals",
                columns: table => new
                {
                    GeneralID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generals", x => x.GeneralID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bodies");

            migrationBuilder.DropTable(
                name: "Generals");
        }
    }
}
