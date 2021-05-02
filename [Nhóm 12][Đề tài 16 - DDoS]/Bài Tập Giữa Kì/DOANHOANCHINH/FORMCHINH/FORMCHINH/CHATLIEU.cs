namespace FORMCHINH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHATLIEU")]
    public partial class CHATLIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHATLIEU()
        {
            HANGHOAs = new HashSet<HANGHOA>();
        }

        [Key]
        [StringLength(20)]
        public string MACHATLIEU { get; set; }

        [Required]
        [StringLength(50)]
        public string TENCHATLIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HANGHOA> HANGHOAs { get; set; }
    }
}
