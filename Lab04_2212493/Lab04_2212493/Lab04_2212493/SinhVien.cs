using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab04_2212493
{
    internal class SinhVien
    {
        public string MSSV {  get; set; }
        public string HoTen { get; set; }
        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop {  get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }


        public SinhVien(string mssv, string ht, bool phai, DateTime ns, string lop, string sdt, string email, string dc, string hinh) 
        { 
            MSSV = mssv;
            HoTen = ht;
            Phai = phai;
            NgaySinh = ns;
            Lop = lop;
            SDT = sdt;
            Email = email;
            DiaChi = dc;
            Hinh = hinh;
        }
    }
}
