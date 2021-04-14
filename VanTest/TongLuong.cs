using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace VanTest
{
    class TongLuong : ITongLuong
    {
        //tinh tong luong nhan vien trong cung phong ban
        //khong hop ly lap khi 1 nhan vien co the goi tinh tong tien cua phon
        public double TongLuongTheoPhong (List<KeyValuePair<string, double>> luongPhongBan, string phongBan)
        {

            double sum = 0;

            //luongPhongBan.Where(lpb => lpb.Key == phongBan).Select(lpb => sum+= lpb.Value);
            foreach (KeyValuePair<string, double> nhanVien in luongPhongBan)
            {
                if (nhanVien.Key == phongBan)
                {
                    sum += nhanVien.Value;
                }
            }

            return sum;

        }
    }
}
