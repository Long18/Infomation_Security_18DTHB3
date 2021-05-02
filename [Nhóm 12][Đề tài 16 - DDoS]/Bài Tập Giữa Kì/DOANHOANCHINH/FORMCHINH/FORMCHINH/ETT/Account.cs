using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FORMCHINH.ETT
{
    class Account
    {
        DANGNHAP D = new DANGNHAP();
        public Account(string TAIKHOAN, string TENHIENTHI, int LOAIID, string MATKHAU = null)
        {
            this.TaiKhoan = TAIKHOAN;
            this.TenHienThi = TENHIENTHI;
            this.LoaiID = LOAIID;
            this.MatKhau = MATKHAU;
        }

        public Account(DataRow row)
        {
            this.TaiKhoan = row["TAIKHOAN"].ToString();
            this.TenHienThi = row["TENHIENTHI"].ToString();
            this.LoaiID = (int)row["LOAI"];
            this.MatKhau = row["MATKHAU"].ToString();
        }

        private int LOAIID;

        public int LoaiID
        {
            get { return LOAIID; }
            set { LOAIID = value; }
        }

        private string MATKHAU;

        public string MatKhau
        {
            get { return MATKHAU; }
            set { MATKHAU = value; }
        }

        private string TENHIENTHI;

        public string TenHienThi
        {
            get { return TENHIENTHI; }
            set { TENHIENTHI = value; }
        }

        private string TAIKHOAN;

        public string TaiKhoan
        {
            get { return TAIKHOAN; }
            set { TAIKHOAN = value; }
        }
    }
}
