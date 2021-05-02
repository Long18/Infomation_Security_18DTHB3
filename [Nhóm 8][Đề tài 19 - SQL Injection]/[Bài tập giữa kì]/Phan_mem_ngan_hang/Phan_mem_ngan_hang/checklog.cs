namespace Phan_mem_ngan_hang
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHECKLOG")]
    public partial class CHECKLOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [StringLength(255)]
        public string TENTK { get; set; }

        [StringLength(225)]
        public string NOIDUNG { get; set; }

        [Key]
        [StringLength(255)]
        public string THOIGIAN { get; set; }

        
    }
}
