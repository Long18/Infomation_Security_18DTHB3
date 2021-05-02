namespace Phan_mem_ngan_hang
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIGIAODICH")]
    public partial class LOAIGIAODICH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIGIAODICH()
        {
            GIAODICHes = new HashSet<GIAODICH>();
        }

        [Key]
        [StringLength(10)]
        public string MALOAI { get; set; }

        [StringLength(20)]
        public string TENLOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICH> GIAODICHes { get; set; }
    }
}
