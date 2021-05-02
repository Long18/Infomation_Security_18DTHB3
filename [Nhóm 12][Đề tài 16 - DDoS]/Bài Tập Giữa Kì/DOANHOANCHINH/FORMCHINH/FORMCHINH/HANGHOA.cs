namespace FORMCHINH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHOA")]
    public partial class HANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGHOA()
        {
            CHITIETHOADONBANs = new HashSet<CHITIETHOADONBAN>();
        }

        [Key]
        [StringLength(20)]
        public string MAHANG { get; set; }

        [Required]
        [StringLength(50)]
        public string TENHANG { get; set; }

        [StringLength(20)]
        public string MACHATLIEU { get; set; }

        public int SOLUONG { get; set; }

        public int DONGIA { get; set; }

        public virtual CHATLIEU CHATLIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }
    }
}
