using System;
using ThuVienTinhTienKhachSan;

namespace AppTinhTienKhachSan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gioThue = 0;  
            int luaChonLoaiPhong;
            LoaiPhong loaiPhongDuocChon = LoaiPhong.Vip;  
            Console.WriteLine("Vui long chon loai phong:");
            Console.WriteLine("\t1. Phong thuong (200k/gio)");
            Console.WriteLine("\t2. Phong VIP (300k/gio)");

            while (true)
            {
                Console.Write("Lua chon cua ban la (1 hoac 2): ");
                string nhapLoaiPhong = Console.ReadLine();

                if (nhapLoaiPhong == "1")
                {
                    loaiPhongDuocChon = LoaiPhong.Thuong;
                    break;
                }
                else if (nhapLoaiPhong == "2")
                {
                    loaiPhongDuocChon = LoaiPhong.Vip;
                    break;
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le, vui long nhap lai.");
                }
            }

            while (true)
            {
                Console.Write("Ban thue phong trong bao lau (gio): ");
                string nhapGio = Console.ReadLine();

                if (!double.TryParse(nhapGio, out gioThue))
                {
                    Console.WriteLine("Ban phai nhap mot so hop le.");
                }
                else if (gioThue <= 0)
                {
                    Console.WriteLine("Thoi gian phai la so duong, vui long nhap lai.");
                }
                else
                {
                    break;  
                }
            }

            double tongTien = TinhTienKhachSan.TinhTongTien(loaiPhongDuocChon, gioThue);
            Console.WriteLine($"\nTong tien phai tra la: {tongTien} VND");  
            Console.ReadLine();  
        }
    }
}
