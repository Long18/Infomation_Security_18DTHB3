namespace Phan_mem_ngan_hang
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBcontext : DbContext
    {
        public DBcontext()
            : base("name=DBcontext")
        {
        }

        public virtual DbSet<CHINHANH> CHINHANHs { get; set; }
        public virtual DbSet<GIAODICH> GIAODICHes { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIGIAODICH> LOAIGIAODICHes { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        //---------------------------------------------------
        public virtual DbSet<CHECKLOG> CHECKLOGs { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHINHANH>()
                .Property(e => e.MACHINHANH)
                .IsUnicode(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.MAGD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.SOTIEN)
                .IsUnicode(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.SOTK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SOCMND)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIGIAODICH>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.LUONGCB)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.TENTK)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MAPHONGBAN)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MACHINHANH)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.MAPHONGBAN)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.SOTK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MATKHAU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.SODU)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);
            //----------------------------------------------------
            modelBuilder.Entity<CHECKLOG>()
                .Property(e => e.TENTK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHECKLOG>()
                .Property(e => e.NOIDUNG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHECKLOG>()
                .Property(e => e.THOIGIAN)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
