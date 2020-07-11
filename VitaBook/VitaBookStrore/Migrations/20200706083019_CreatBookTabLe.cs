using Microsoft.EntityFrameworkCore.Migrations;

namespace VitaBookStrore.Migrations
{
    public partial class CreatBookTabLe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "AvatarPath", "Depscrip", "GenreId", "Name", "Price" },
                values: new object[] { "Nguyễn Trí Đoàn- Nhã Uyên", "Để-con-được-ốm.jpg", "Để con được ốm cùng với những câu chuyện nhỏ thú vị của người mẹ là lời khuyên mang tính chuyên môn, giải đáp cụ thể từ bác sỹ Nguyễn Trí Đoàn, giúp hóa giải những hiểu lầm từ kinh nghiệm dân gian được truyền lại, cũng như lý giải một cách khoa học những thông tin chưa đúng đắn đang được lưu truyền hiện nay, mang đến góc nhìn đúng đắn nhất cho mỗi hiện tượng, sự việc với những kiến thức y khoa hiện đại được cập nhật liên tục.", 2, "	Để con được ốm", 56000 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "AvatarPath", "Depscrip", "Name", "Price" },
                values: new object[] { "Jessica Joelle Alexander - Iben Dissing Sandahl", "1888c2ad-68fd-41ed-a760-89aab2b2f7f2_ sach-nuoi-day-mot-dua-tre-hanh-phuc.jpg", "Nuôi dạy một đứa trẻ hạnh phúc là cuốn cẩm nang dành cho cha mẹ đang có một trải nghiệm khó khăn, gian truân, nhưng cũng vui sướng và đầy viên mãn. Dù cho mọi người có đồng ý với mọi khía cạnh của kiểu Đan Mạch hay không, đây chắc chắn là một miếng trầu để mào đầu nhiều câu chuyện. Những ý tưởng này chính là hạt giống cho một phong trào đời thường và giúp nó phát triển thành những gì nó là ngày hôm nay.", "Nuôi dạy một đứa trẻ hạnh phúc", 75000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "AvatarPath", "Depscrip", "GenreId", "Name", "Price" },
                values: new object[] { "Hoàng Hùng", "~\\images\\images (2).jpg", "Để học tốt Toán lớp 7, loạt bài Giải bài tập Toán lớp 7 Đại số, Hình học học kì 1 và học kì 2 bám sát nội dung sách giáo khoa Toán lớp 7 Tập 1 và Tập 2.", 1, "Toán", 50000 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "AvatarPath", "Depscrip", "Name", "Price" },
                values: new object[] { "Hoàng Hùng", "~\\images\\images (2).jpg", "Để học tốt Toán lớp 7, loạt bài Giải bài tập Toán lớp 7 Đại số, Hình học học kì 1 và học kì 2 bám sát nội dung sách giáo khoa Toán lớp 7 Tập 1 và Tập 2.", "Văn", 30000 });
        }
    }
}
