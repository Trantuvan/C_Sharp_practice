using System.Collections.Generic;
namespace VanTest
{
public class Employee
    {
        //default access modifier for var in class (private)
        public string ten;
        public string maSoNhanVien;
        public string phongBan;
        public string email;
        public double luong;

        public Employee(string ten, string maSoNhanVien, string phongBan, string email, double luong)
        {
            this.ten = ten;
            this.maSoNhanVien = maSoNhanVien;
            this.phongBan = phongBan;
            this.email = email;
            this.luong = luong;
        }

        //properties for fields
        public string GetAndSetTen { get; set; }

        public string GetAndSetMaSoNhanVien { get; set; }

        public string GetAndSetPhongBan { get; set; } 

        public string GetAndSetEmail { get; set; }

        public double GetAndSetLuong { get; set; }

    }
}
