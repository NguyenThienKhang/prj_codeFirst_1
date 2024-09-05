using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace prj_codeFirst_02
{
   public class QLSVDBContext:DbContext
    {
        public QLSVDBContext() : base("QLSV") { }
        public DbSet<KHOA> KHOAs { get; set; }
        public DbSet<SINHVIEN> SINHVIENs { get; set; }
        public DbSet<MONHOC> MONHOCs { get; set; }
        public DbSet<KETQUA> KETQUAs { get; set; }


    }
}
