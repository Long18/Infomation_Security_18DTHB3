namespace FORMCHINH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("checklog")]
    public partial class checklog
    {
        [Key]
        [StringLength(255)]
        public string ngay { get; set; }

        [StringLength(255)]
        public string noidung { get; set; }
    }
}
