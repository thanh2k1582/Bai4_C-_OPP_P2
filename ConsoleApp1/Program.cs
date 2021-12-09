using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho quanLyCanHo = new KhuPho();
            Console.WriteLine("Nhap so ho gia dinh");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n\n\nNhap gia dinh thu {0}",i+1);
                quanLyCanHo.NhapHGD();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Gia dinh thu {0}", i + 1);
                quanLyCanHo.XuatHGD(quanLyCanHo.getListHoGiaDinh());
            }


        }
    }
}
