using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_ngan_hang
{
   public class Classthongtin
    {
        public string MAGD { get; set; }
        public string MANV { get; set; }
        public string MAKH { get; set; }
        [Display(Name = "TENKH")]
        public string HOTEN { get; set; }
        [Display(Name = "GIới tính")]
        public string GIOITINH { get; set; }
        public DateTime NGAYSINH { get; set; }

        public string DIACHI { get; set; }

        public string HOKHAU { get; set; }
        public string SDT { get; set; }
        public string SOTIEN { get; set; }
        public string NOIDUNG { get; set; }
        public DateTime GIOGD { get; set; }
        [Display(Name = " Hình thức GD")]
        public string HINHTHUC { get; set; }
        public DateTime NGAYGD { get; set; }
    }
}
