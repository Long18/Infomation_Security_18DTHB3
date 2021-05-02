namespace Phan_mem_ngan_hang
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOAN()
        {
            GIAODICHes = new HashSet<GIAODICH>();
        }

        [Key]
        [StringLength(10)]
        public string SOTK { get; set; }

        [StringLength(6)]
        public string MATKHAU { get; set; }

        [StringLength(15)]
        public string SODU { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYHIEULUC { get; set; }

        [StringLength(10)]
        public string MAKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICH> GIAODICHes { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
