namespace AucApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            bidDatas = new HashSet<bidData>();
        }

        //[Required]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        [Required]
        public int min_bid { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime bid_end_time { get; set; }

        [Required]
        [StringLength(128)]
        public string user_id { get; set; }

        [Required]
        public int Cid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bidData> bidDatas { get; set; }
    }
}
