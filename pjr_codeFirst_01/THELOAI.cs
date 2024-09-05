using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pjr_codeFirst_01
{
    [Table("THELOAI")]
    class THELOAI
    {
        [Key]
        [StringLength(2)]
        public string MaTL { get; set; }
        [StringLength(50)]
        public string TenTL { get; set; }
    }
}
