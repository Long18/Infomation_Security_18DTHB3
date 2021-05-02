namespace FORMCHINH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONBAN")]
    public partial class HOADONBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONBAN()
        {
            CHITIETHOADONBANs = new HashSet<CHITIETHOADONBAN>();
        }

        [Key]
        [StringLength(20)]
        public string MAHOADON { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYBAN { get; set; }

        [StringLength(20)]
        public string MANHANVIEN { get; set; }

        [StringLength(20)]
        public string MAKHACH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
