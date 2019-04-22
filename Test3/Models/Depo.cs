using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Test3.Models
{
    [Table("Depo")]
    public partial class Depo
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(HataMesajlari),ErrorMessageResourceName = "Requried_Depo_Ad")]
        [StringLength(80)]
        public string Ad { get; set; }

        [Required(ErrorMessageResourceType = typeof(HataMesajlari),ErrorMessageResourceName = "Required_Depo_Soyad")]
        [StringLength(100)]
        public string Soyad { get; set; }
    }
}