using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharacterNoteBook.Migrations
{
    public partial class CreateCharacterNoteBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    TheSpeciesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.TheSpeciesID);
                });

            migrationBuilder.CreateTable(
                name: "UsedCharacters",
                columns: table => new
                {
                    UsedCharacterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TheSpeciesID = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Species = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedCharacters", x => x.UsedCharacterID);
                    table.ForeignKey(
                        name: "FK_UsedCharacters_Species_TheSpeciesID",
                        column: x => x.TheSpeciesID,
                        principalTable: "Species",
                        principalColumn: "TheSpeciesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "TheSpeciesID", "Name" },
                values: new object[] { 1, "Characters" });


            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "TheSpeciesID", "Name" },
                values: new object[] { 3, "Story Elements" });

            migrationBuilder.InsertData(
                table: "UsedCharacters",
                columns: new[] { "UsedCharacterID", "TheSpeciesID", "Code", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 1, "1", "Vitriol (Medical raw material supplier)", "Mermaid" },
                    { 2, 1, "1", "Copper (Fire awareness publicity volunteer)", "Phoenix" },
                    { 3, 1, "2", "MoLing (Engineering painter with highly competitive science)", "Fox" },
                    { 4, 1, "2", "JunQing (Surrealist and idealist writer)", "Bunny" },
                    { 5, 1, "3", "Erin (Medical expert with a small amount of anti social consciousness)", "Bear" },
                    { 6, 1, "3", "Phoebus (A peace ambassador who has made great contributions to society)", "Bear" },
                    { 13, 1, "4", "Sofia (Versatile vtuber)", "Mermaid" },
                    { 14, 1, "4", "Hydro (Marine Environmental Protection Ambassador)", "Jellyfish" },
                    { 15, 3, "5", "One of them picked up a stray cat", " " }, 
                    { 16, 3, "6", "They live in the same apartment, but today one of them triggered a fire while cooking for everyone", " " }, 
                    { 17, 3, "7", "Two of them were photographed by their classmates when they were traveling together and said they were lovers, but they were not", " " }, 
                    { 18, 3, "8", "The police broke into their party and took one of them", " " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsedCharacters_TheSpeciesID",
                table: "UsedCharacters",
                column: "TheSpeciesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsedCharacters");

            migrationBuilder.DropTable(
                name: "Species");
        }
    }
}
