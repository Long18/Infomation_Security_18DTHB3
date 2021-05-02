namespace Phan_mem_ngan_hang
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            GIAODICHes = new HashSet<GIAODICH>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string HOTENNV { get; set; }

        [StringLength(5)]
        public string GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(50)]
        public string CHUCVU { get; set; }

        [StringLength(15)]
        public string LUONGCB { get; set; }

        [StringLength(50)]
        public string TENTK { get; set; }

        [StringLength(255)]
        public string MATKHAU { get; set; }

        [StringLength(20)]
        public string MAPHONGBAN { get; set; }

        [StringLength(10)]
        public string MACHINHANH { get; set; }

        public virtual CHINHANH CHINHANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICH> GIAODICHes { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        public DateTime? thoigiandangnhap { get; set; }

        public DateTime? thoigiandoimatkhau { get; set; }

        public DateTime? thoigiandangxuat { get; set; }
    }
}
