using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;
using System;
using System.Linq;
namespace MVCMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCMovieContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<MVCMovieContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.Movie.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.Movie.AddRange(
                new Movie
                {
                    NameMovie = "Batman: Vạch Trần Sự Thật",
                    Premiere = DateTime.Parse("2022-04-06"),
                    Time = "183 phút",
                    Genre = "Hành Động-Kinh Điển",
                    Price = 198000
                },
                new Movie
                {
                    NameMovie = "No Way Home",
                    Premiere = DateTime.Parse("2022-4-3"),
                    Genre = "Hành Động-Tình Cảm",
                    Time = "192 phút",
                    Price = 189000
                }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}