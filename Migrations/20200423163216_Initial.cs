using Microsoft.EntityFrameworkCore.Migrations;

namespace WADNghi13A.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OneProjectOneWeek",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee = table.Column<string>(maxLength: 50, nullable: false),
                    Project = table.Column<string>(maxLength: 50, nullable: false),
                    ArriveDT = table.Column<string>(maxLength: 50, nullable: false),
                    DepartureDT = table.Column<string>(maxLength: 50, nullable: false),
                    OneWeek = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneProjectOneWeek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    FamilyName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    DOB = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 50, nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OneProjectOneWeek");

            migrationBuilder.DropTable(
                name: "Personnel");
        }
    }
}
