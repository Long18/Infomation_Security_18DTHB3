namespace lancuoi
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
            CHITIETBANGLUONGs = new HashSet<CHITIETBANGLUONG>();
        }

        [Key]
        [StringLength(20)]
        public string MANV { get; set; }

        [Required]
        [StringLength(30)]
        public string TENNV { get; set; }

        [Required]
        [StringLength(30)]
        public string MUCLUONG { get; set; }

        [Required]
        [StringLength(30)]
        public string BACLUONG { get; set; }

        [Required]
        [StringLength(20)]
        public string MAPB { get; set; }

        [Required]
        [StringLength(5)]
        public string PHAI { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(11)]
        public string DIENTHOAI { get; set; }

        [Required]
        [StringLength(30)]
        public string TRINHDOCM { get; set; }

        [Required]
        [StringLength(50)]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANGLUONG> CHITIETBANGLUONGs { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
