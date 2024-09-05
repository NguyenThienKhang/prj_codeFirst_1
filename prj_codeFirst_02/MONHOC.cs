using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_codeFirst_02
{
    [Table("MONHOC")]
   public class MONHOC
    {
        [Key]
        [StringLength(2)]
        public string MaMH { get; set; }

        [StringLength(50)]
        public string TenMH { get; set; }
        public int SoTiet { get; set; }
        public List<KETQUA> KETQUAs { get; set; }

    }
}
