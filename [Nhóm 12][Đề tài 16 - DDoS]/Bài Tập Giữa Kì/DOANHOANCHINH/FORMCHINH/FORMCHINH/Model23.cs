using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FORMCHINH
{
    public partial class Model23 : DbContext
    {
        public Model23()
            : base("name=Model23")
        {
        }

        public virtual DbSet<checklog> checklogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
