namespace AucApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bidData")]
    public partial class bidData
    {
        [Key]
        [Column(Order = 0)]
        public string user_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int prod_id { get; set; }

        public int bid_value { get; set; }

        public virtual product product { get; set; }
    }
}
