namespace Phan_mem_ngan_hang
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAODICH")]
    public partial class GIAODICH
    {
        [Key]
        [StringLength(10)]
        public string MAGD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYGD { get; set; }

        public TimeSpan? GIOGD { get; set; }

        [StringLength(200)]
        public string NOIDUNG { get; set; }

        [StringLength(15)]
        public string SOTIEN { get; set; }

        [StringLength(20)]
        public string HINHTHUCGD { get; set; }

        [StringLength(10)]
        public string MALOAI { get; set; }

        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(10)]
        public string MAKH { get; set; }

        [StringLength(10)]
        public string SOTK { get; set; }

        public virtual LOAIGIAODICH LOAIGIAODICH { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
