using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FORMCHINH
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model22")
        {
        }

        public virtual DbSet<CHATLIEU> CHATLIEUx { get; set; }
        public virtual DbSet<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }
        public virtual DbSet<HOADONBAN> HOADONBANs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHATLIEU>()
                .Property(e => e.MACHATLIEU)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADONBAN>()
                .Property(e => e.MAHANG)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADONBAN>()
                .Property(e => e.MAHOADON)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.MAHANG)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.MACHATLIEU)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CHITIETHOADONBANs)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADONBAN>()
                .Property(e => e.MAHOADON)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONBAN>()
                .Property(e => e.MANHANVIEN)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONBAN>()
                .Property(e => e.MAKHACH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONBAN>()
                .HasMany(e => e.CHITIETHOADONBANs)
                .WithRequired(e => e.HOADONBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKHACH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DIENTHOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANHANVIEN)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.DIENTHOAI)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
