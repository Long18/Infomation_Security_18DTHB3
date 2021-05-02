namespace FORMCHINH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGNHAP")]
    public partial class DANGNHAP
    {
        [Key]
        [StringLength(150)]
        public string TAIKHOAN { get; set; }

        [StringLength(150)]
        public string MATKHAU { get; set; }

        [StringLength(150)]
        public string TENHIENTHI { get; set; }

        public int? LOAIID { get; set; }
    }
}
