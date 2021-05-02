using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace pjQLLNV
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<BANGLUONG> BANGLUONGs { get; set; }
        public virtual DbSet<CHITIETBANGLUONG> CHITIETBANGLUONGs { get; set; }
        public virtual DbSet<DMTinhluong> DMTinhluongs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<LICHSU> LICHSUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.THANG)
                .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
                .HasMany(e => e.CHITIETBANGLUONGs)
                .WithRequired(e => e.BANGLUONG)
                .HasForeignKey(e => new { e.THANG, e.MANV })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHITIETBANGLUONG>()
                .Property(e => e.THANG)
                .IsUnicode(false);

            modelBuilder.Entity<DMTinhluong>()
                .HasMany(e => e.CHITIETBANGLUONGs)
                .WithRequired(e => e.DMTinhluong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHITIETBANGLUONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGBAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.PHONGBAN)
                .WillCascadeOnDelete(false);
        }
    }
}
