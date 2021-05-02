namespace pjQLLNV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOANADM")]
    public partial class TAIKHOANADM
    {
        [Key]
        [Column("TAIKHOANADM")]
        [StringLength(20)]
        public string TAIKHOANADM1 { get; set; }

        [Required]
        [StringLength(20)]
        public string MATKHAUADM { get; set; }
    }
}
