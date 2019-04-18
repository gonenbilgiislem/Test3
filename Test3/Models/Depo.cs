using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    [Table("Depo")]
    public partial class Depo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Ad { get; set; }
    }
}