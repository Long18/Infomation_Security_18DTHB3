namespace lancuoi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGLUONG")]
    public partial class BANGLUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGLUONG()
        {
            CHITIETBANGLUONGs = new HashSet<CHITIETBANGLUONG>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string THANG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MANV { get; set; }

        [Required]
        [StringLength(30)]
        public string TONGTIENLUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBANGLUONG> CHITIETBANGLUONGs { get; set; }
    }
}
