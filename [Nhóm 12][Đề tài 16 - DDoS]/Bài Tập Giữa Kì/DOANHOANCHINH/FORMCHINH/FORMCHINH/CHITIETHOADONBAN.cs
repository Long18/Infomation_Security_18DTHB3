namespace FORMCHINH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADONBAN")]
    public partial class CHITIETHOADONBAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MAHANG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MAHOADON { get; set; }

        public int SOLUONG { get; set; }

        public int DONGIA { get; set; }

        public int THANHTIEN { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }

        public virtual HOADONBAN HOADONBAN { get; set; }
    }
}
