using System;
using System.Collections.Generic;
using System.Text;

namespace AppTinhTienKhachSanKoTV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double Gio = 0, loaiphong = 0;
            bool vonglap = true;
            while (vonglap)
            {
                Console.WriteLine("Vui long chon loai phong !");
                Console.WriteLine("\t Phong thuong (200k/h) => Bam phim 1");
                Console.WriteLine("\t Phong Vip (300k/h) => Bam phim 2");
                Console.Write("\t\t Lua chon cua ban la :"); a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    loaiphong = 200000;
                }
                else if (a == 2)
                {
                    loaiphong = 300000;
                }
                else
                {
                    Console.WriteLine("Chon lai phong !");
                    continue;
                }
                Console.Write("Ban thue trong bao lau (gio) :"); string input = Console.ReadLine();
                if (double.TryParse(input, out Gio) && Gio > 0)
                {
                    vonglap = false;
                }
                else
                {
                    continue;
                }
                double tongTien = loaiphong * Gio;
                Console.WriteLine($"\t Tong tien phai tra la: {tongTien} VND");
                Console.ReadLine();
            }
        }
    }
}
