using System;
using System.Collections.Generic;
using System.Text;

namespace ThuVienTinhTienKhachSan
{
    public enum LoaiPhong
    {
        Vip,
        Thuong
    }
    public class TinhTienKhachSan
    {
        private const int PhongVip = 300000;
        private const int PhongThuong = 200000;

        public static double TinhTongTien(LoaiPhong Phong, double Gio)
        {
            double giaTien = Phong == LoaiPhong.Vip ? PhongVip : PhongThuong;
            return giaTien * Gio;
        }
    }
    
}
