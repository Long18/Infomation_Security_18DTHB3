namespace pjQLLNV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETBANGLUONG")]
    public partial class CHITIETBANGLUONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string THANG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string MASP { get; set; }

        [Required]
        [StringLength(6)]
        public string SLSP { get; set; }

        public virtual BANGLUONG BANGLUONG { get; set; }

        public virtual DMTinhluong DMTinhluong { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
