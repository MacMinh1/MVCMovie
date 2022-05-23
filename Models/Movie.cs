using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Tên Phim")]
        public string NameMovie { get; set; }

        [Display(Name = "Khởi Chiếu")]
        [DataType(DataType.Date)]
        public DateTime Premiere { get; set; }

        [Display(Name = "Thể Loại")]
        public string Genre { get; set; }

        [Display(Name = "Thời Lượng")]
        public string Time { get; set; }

        [Display(Name = "Giá Tiền")]
        public decimal Price { get; set; }
    }
}

