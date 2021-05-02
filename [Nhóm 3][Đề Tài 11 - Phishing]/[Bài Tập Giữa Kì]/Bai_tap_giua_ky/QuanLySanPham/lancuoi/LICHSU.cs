namespace lancuoi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHSU")]
    public partial class LICHSU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string TAIKHOAN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string THOIGIAN { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string NOIDUNG { get; set; }
    }
}
