
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1057_UTS_PBO.App.Model
{
    public class M_Tugas
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string judul { get; set; }
        [Required]
        public string deskripsi { get; set; }
        [Required]
        public string deadline { get; set; }

    }
}