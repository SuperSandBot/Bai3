using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            QLKhuDat ql = new QLKhuDat();

            int chon = 0;
            do
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1.Tao DS.");
                Console.WriteLine("2.Xuat DS");
                Console.WriteLine("3.Xuat Xuat Tang Dan");
                Console.WriteLine("4.Xuat Theo Gia Ban Va Dien Tich");
                Console.WriteLine("5.Tinh Don Gia Trung Binh Cua Dat 1m2");
                Console.WriteLine("0.Exit.");
                Console.Write("Chon: ");
                Console.WriteLine("----------------------------");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap so Khu Dat trong DS: ");
                        int sl = int.Parse(Console.ReadLine());
                        ql.NhapDSDat(sl);
                        break;
                    case 2:
                        ql.XuatDSKhuDat();
                        break;
                    case 3:
                        ql.XuatTangDan();
                        break;
                    case 4:
                        Console.Write("Nhap Gia Ban: ");
                        int giaban = int.Parse(Console.ReadLine());
                        Console.Write("Nhap Dien Tich: ");
                        float dientich = float.Parse(Console.ReadLine());
                        ql.XuatTheoGiaBanVaDienTich(giaban,dientich);
                        break;
                    case 5:
                        ql.TinhDonGiaTrungBinhCuaDat1m2();
                        break;
                    default:
                        chon = 0;
                        break;
                }
            } while (chon != 0);
        }
    }
}
