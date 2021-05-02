namespace FORMCHINH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADONBANs = new HashSet<HOADONBAN>();
        }

        [Key]
        [StringLength(20)]
        public string MAKHACH { get; set; }

        [Required]
        [StringLength(50)]
        public string TENKHACH { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(10)]
        public string DIENTHOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONBAN> HOADONBANs { get; set; }
    }
}
