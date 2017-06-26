using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AucApp.Models
{
    public class categories
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }

}