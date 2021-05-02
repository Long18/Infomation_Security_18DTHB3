namespace lancuoi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [Column("TAIKHOAN")]
        [StringLength(20)]
        public string TAIKHOAN1 { get; set; }

        [Required]
        [StringLength(20)]
        public string MATKHAU { get; set; }

        [StringLength(30)]
        public string KIEMSOAT { get; set; }
    }
}
