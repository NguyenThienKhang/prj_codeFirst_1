using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_codeFirst_02
{
    [Table("SINHVIEN")]
    public class SINHVIEN
    {
        [Key]
        [StringLength(3)]
        public string MaSV { get; set; }
        [StringLength(50)]
        public string HoSV { get; set; }
        [StringLength(10)]
        public  string  TenSV { get; set; }

        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string MaKH { get; set; }
        public int HocBong { get; set; }
        public KHOA khoa { get; set; }
        public List<KETQUA>KETQUAs { get; set; }
    }
}
