using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace pjr_codeFirst_01
{
    [Table("PHIM")]
    class PHIM
    {
        [Key]
        [StringLength(4)]
        public string MaPH { get; set; }
        [StringLength(50)]
        public string TenPH { get; set; }
        public int  SoTap { get; set; }
        public string MaTL { get; set; }
        public THELOAI theloai { get; set; }
    }
}
