using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace qlquancf.DAO
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QLCF")
        {
        }

        public virtual DbSet<checklog> checklogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<checklog>()
                .Property(e => e.ngay)
                .IsUnicode(false);

            modelBuilder.Entity<checklog>()
                .Property(e => e.noidung)
                .IsUnicode(false);
        }
    }
}
