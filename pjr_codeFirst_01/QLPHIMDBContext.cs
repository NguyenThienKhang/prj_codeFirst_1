using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;// Thêm
namespace pjr_codeFirst_01
{
    class QLPHIMDBContext:DbContext
    {
        // Xây dựng hàm khởi tạo
        public QLPHIMDBContext() : base("QLPHIM") { }
        public DbSet<THELOAI> theloais { get; set; }
        public DbSet<PHIM>  phims { get; set; }

    }
}
