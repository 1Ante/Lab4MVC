using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4MVC.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 40, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    BorrowTime = table.Column<string>(nullable: false),
                    IsBorrowed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 15, nullable: false),
                    LastName = table.Column<string>(maxLength: 15, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBooks",
                columns: table => new
                {
                    CustomerBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBooks", x => x.CustomerBookId);
                    table.ForeignKey(
                        name: "FK_CustomerBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBooks_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BorrowTime", "Description", "IsBorrowed", "Title" },
                values: new object[,]
                {
                    { 1, "2022-06-20", "En bok om rymden, planeter, liv i universum, stjärnor med mera.", true, "Astronomiska upptäckter" },
                    { 2, "", "En bok med recept på maträtter som går snabbt att laga och är billiga.", false, "Enkla matrecept" },
                    { 3, "2022-06-25", "Gymnasieskolans matematik-kurs på C-nivå.", true, "Matematik C" },
                    { 4, "2022-06-30", "Lärobok i programering i språket C#.", true, "Programmering i C#" },
                    { 5, "2022-06-18", "En spännade kriminalroman om ett mord i Örnsköldsvik.", true, "Mordet i Örnsköldsvik" },
                    { 6, "", "En bok om hockeyligan NHL genom tiderna.", false, "NHL genom tiderna" },
                    { 7, "2022-06-29", "En bok om programmering i programspråket Python.", true, "Programmering i Python" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Blåbärsvägen 1", "Johan", "Svensson", "089876543" },
                    { 2, "Svartvinbärsvägen 3", "Mikael", "Johansson", "088876543" },
                    { 3, "Hallonvägen 10", "Anna", "Persson", "088876543" },
                    { 4, "Päronvägen 15", "Ingrid", "Karlsson", "087576443" },
                    { 5, "Lingonvägen 25", "Per", "Bergström", "089375423" }
                });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 4, 4, 1 },
                    { 2, 5, 2 },
                    { 5, 3, 2 },
                    { 3, 7, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBooks_BookId",
                table: "CustomerBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBooks_CustomerId",
                table: "CustomerBooks",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
