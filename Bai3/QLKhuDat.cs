using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class QLKhuDat
    {
        public List<KhuDat> KD = new List<KhuDat>();

        public void NhapDSDat(int n)
        {
            for (int i = 0; i< n; i++)
            {
                KhuDat kd = new KhuDat();

                kd.Input();

                KD.Add(kd);
            }
        }

        public void XuatDSKhuDat()
        {
            int i = 0;
            foreach(KhuDat kd in KD)
            {
                Console.WriteLine(i+"."+kd.Tosting());
                i++;
            }
        }


        public void XuatDS(List<KhuDat> list)
        {
            int i = 0;
            foreach (KhuDat kd in list)
            {
                Console.WriteLine(i + "." + kd.Tosting());
                i++;
            }
        }

        public void XuatTangDan()
        {
            List<KhuDat> list = KD.OrderBy(p => p.dientich).ToList();

            XuatDS(list);
        }

        public void XuatTheoGiaBanVaDienTich(int giaban , float dientich)
        {
            List<KhuDat> list = KD.Where(p => p.giaBan == giaban && p.dientich == dientich).ToList();

            XuatDS(list);
        }

        public void TinhDonGiaTrungBinhCuaDat1m2()
        {
            List<KhuDat> list = KD.Where(p => p.dientich > 1000).ToList();

            float tong = list.Sum(p => p.giaBan);

            Console.WriteLine("DonGia = " + tong);
        }
    }
}
