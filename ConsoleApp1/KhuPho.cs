using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class KhuPho
    {
        private List<HoGiaDinh> ListHoGiaDinh = null;
        Nguoi[] thanhVien = new Nguoi[6];
        public KhuPho()
        {
            ListHoGiaDinh = new List<HoGiaDinh>();
        }
        public void NhapHGD()
        {
            HoGiaDinh hgd = new HoGiaDinh();
            Console.Write("Nhap dia chi: ");
            hgd.DiaChi = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap so thanh vien trong gia dinh: ");
            hgd.SoThanhVien = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < hgd.SoThanhVien; i++)
            {
                Console.WriteLine("********************");
                Console.WriteLine("Nhap thanh vien thu {0}: ",i+1);
                thanhVien[i] = new Nguoi();
                Console.Write("Ho va ten: ");
                thanhVien[i].Hoten = Convert.ToString(Console.ReadLine());
                Console.Write("Tuoi: ");
                thanhVien[i].Tuoi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nghe nghiep: ");
                thanhVien[i].NgheNghiep = Convert.ToString(Console.ReadLine());
                Console.Write("So CMND: ");
                thanhVien[i].SoCMND = Convert.ToString(Console.ReadLine());
            }
            ListHoGiaDinh.Add(hgd);
        }

        public void XuatHGD(List<HoGiaDinh> listHGD)
        {
            foreach (HoGiaDinh hogiadinh in listHGD)
            {
                Console.WriteLine("\n\n\n\n******************************************************************");
                Console.WriteLine("Dia chi: {0}", hogiadinh.DiaChi);
                Console.WriteLine("So thanh vien: {0}", hogiadinh.SoThanhVien);
                for (int i = 0;i < hogiadinh.SoThanhVien ; i++)
                {
                    Console.WriteLine("************");
                    Console.WriteLine("Thong tin thanh vien thu {0}:",i+1);
                    Console.WriteLine("Ho ten : {0}",thanhVien[i].Hoten);
                    Console.WriteLine("Tuoi : {0}",thanhVien[i].Tuoi);
                    Console.WriteLine("Nghe nghiep : {0}",thanhVien[i].NgheNghiep);
                    Console.WriteLine("So CMND : {0}",thanhVien[i].SoCMND);
                }
            }
            Console.WriteLine();
        }
        public List<HoGiaDinh> getListHoGiaDinh()
        {
            return ListHoGiaDinh;
        }
    }
}
