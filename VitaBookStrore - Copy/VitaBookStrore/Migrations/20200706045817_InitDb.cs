using Microsoft.EntityFrameworkCore.Migrations;

namespace VitaBookStrore.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    AvatarPath = table.Column<string>(nullable: true),
                    GenreId = table.Column<int>(nullable: false),
                    Depscrip = table.Column<string>(nullable: true),
                    Remain = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[] { 1, " Sách kĩ năng" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[] { 2, " Sách thiếu nhi" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[] { 3, " Sách kinh doanh" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "AvatarPath", "Category", "Depscrip", "GenreId", "Name", "Price", "Remain" },
                values: new object[] { 1, "Hoàng Hùng", "~\\images\\images (2).jpg", null, "Để học tốt Toán lớp 7, loạt bài Giải bài tập Toán lớp 7 Đại số, Hình học học kì 1 và học kì 2 bám sát nội dung sách giáo khoa Toán lớp 7 Tập 1 và Tập 2.", 1, "Toán", 50000, 0 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "AvatarPath", "Category", "Depscrip", "GenreId", "Name", "Price", "Remain" },
                values: new object[] { 2, "Hoàng Hùng", "~\\images\\images (2).jpg", null, "Để học tốt Toán lớp 7, loạt bài Giải bài tập Toán lớp 7 Đại số, Hình học học kì 1 và học kì 2 bám sát nội dung sách giáo khoa Toán lớp 7 Tập 1 và Tập 2.", 2, "Văn", 30000, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
