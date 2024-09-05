using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_codeFirst_02
{
    [Table("KHOA")]
   public class KHOA
    {
        [Key]
        [StringLength(2)]
        public string MaKH { get; set; }
        [StringLength(50)]
        public string TenKH { get; set; }
        public List<SINHVIEN>SINHVIENs { get; set; }

    }
}
