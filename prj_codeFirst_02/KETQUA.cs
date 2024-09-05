using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_codeFirst_02
{
    [Table("KETQUA")]
    public class KETQUA
    {
        [Key]
        [StringLength(3)]
        [Column(Order =0)]
        public string MaSV { get; set; }
        [Key]
        [StringLength(2)]
        [Column(Order = 1)]

        public string MaMH { get; set; }
        public int Diem { get; set; }
        public SINHVIEN sinhvien { get; set; }
        public MONHOC monhoc { get; set; }


    }
}
