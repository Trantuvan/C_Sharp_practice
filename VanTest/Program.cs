using System;
using System.Collections.Generic;
using System.Linq;

namespace VanTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee van = new Employee("van","ieieiu15077","FHM","trantuvan.kan@gmail.com",50_000);
            Employee nhi = new Employee("van", "ieieiu15077", "FHM", "trantuvan.kan@gmail.com", 50_000);
            Employee lam = new Employee("van", "ieieiu15077", "EC", "trantuvan.kan@gmail.com", 20_000);

            List<KeyValuePair<string, double>> luongNhanVienContainer = new List<KeyValuePair<string, double>>() { 
                
                new KeyValuePair<string, double>(van.phongBan, van.luong),
                new KeyValuePair<string, double>(nhi.phongBan, nhi.luong),
                new KeyValuePair<string, double>(lam.phongBan, lam.luong),
            };

            ITongLuong tinhLuong = new TongLuong();
            double tong = tinhLuong.TongLuongTheoPhong(luongNhanVienContainer, van.phongBan);

            Console.WriteLine("tong luong nhan vien trong phong ban {0} la: {1}", van.phongBan, tong);
    }
    }
}
