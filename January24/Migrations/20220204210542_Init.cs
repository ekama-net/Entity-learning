using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace January24.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Kids",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "INTEGER", nullable: false)
            //            .Annotation("Sqlite:Autoincrement", true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Kids", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Peoples",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "INTEGER", nullable: false)
            //            .Annotation("Sqlite:Autoincrement", true),
            //        Name = table.Column<string>(type: "TEXT", nullable: true),
            //        Age = table.Column<int>(type: "INTEGER", nullable: false),
            //        KidId = table.Column<int>(type: "INTEGER", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Peoples", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Peoples_Kids_KidId",
            //            column: x => x.KidId,
            //            principalTable: "Kids",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Peoples_KidId",
            //    table: "Peoples",
            //    column: "KidId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Peoples");

            //migrationBuilder.DropTable(
            //    name: "Kids");
        }
    }
}
