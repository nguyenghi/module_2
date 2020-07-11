using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitaBookStrore.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData
                (
                new Book()
                {
                    Id= 1,
                    Name= "	Để con được ốm",
                    Price = 56000,
                    Author = "Nguyễn Trí Đoàn- Nhã Uyên",
                    AvatarPath = @"Để-con-được-ốm.jpg",
                    Depscrip = "Để con được ốm cùng với những câu chuyện nhỏ thú vị của người mẹ là lời khuyên mang tính chuyên môn, giải đáp cụ thể từ bác sỹ Nguyễn Trí Đoàn, giúp hóa giải những hiểu lầm từ kinh nghiệm dân gian được truyền lại, cũng như lý giải một cách khoa học những thông tin chưa đúng đắn đang được lưu truyền hiện nay, mang đến góc nhìn đúng đắn nhất cho mỗi hiện tượng, sự việc với những kiến thức y khoa hiện đại được cập nhật liên tục.",
                    GenreId = 2
                },
                 new Book()
                 {
                     Id = 2,
                     Name = "Nuôi dạy một đứa trẻ hạnh phúc",
                     Price = 75000,
                     Author = "Jessica Joelle Alexander - Iben Dissing Sandahl",
                     AvatarPath = @"1888c2ad-68fd-41ed-a760-89aab2b2f7f2_ sach-nuoi-day-mot-dua-tre-hanh-phuc.jpg",
                     Depscrip = "Nuôi dạy một đứa trẻ hạnh phúc là cuốn cẩm nang dành cho cha mẹ đang có một trải nghiệm khó khăn, gian truân, nhưng cũng vui sướng và đầy viên mãn. Dù cho mọi người có đồng ý với mọi khía cạnh của kiểu Đan Mạch hay không, đây chắc chắn là một miếng trầu để mào đầu nhiều câu chuyện. Những ý tưởng này chính là hạt giống cho một phong trào đời thường và giúp nó phát triển thành những gì nó là ngày hôm nay.",
                     GenreId = 2
                 });
            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    GenreId = 1,
                    GenreName =" Sách kĩ năng"
                },
                new Genre()
                {
                    GenreId = 2,
                    GenreName = " Sách thiếu nhi"
                },
                new Genre()
                {
                    GenreId = 3,
                    GenreName = " Sách kinh doanh"
                });
        }
    }
}
