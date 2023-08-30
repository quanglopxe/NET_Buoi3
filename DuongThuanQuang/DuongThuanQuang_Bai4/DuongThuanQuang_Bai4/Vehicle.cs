using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai4
{
    class Vehicle
    {
        private string chuXe;
        private string loaiXe;
        private int triGiaXe;
        private int dungTich;

        public string ChuXe
        {
            get { return chuXe; }
            set
            {
                chuXe = value;
            }
        }
        public string LoaiXe
        {
            get { return loaiXe; }
            set
            {
                loaiXe = value;
            }
        }
        public int TriGiaXe
        {
            get { return triGiaXe; }
            set
            {
                triGiaXe = value;
                if (triGiaXe < 0)
                    throw new Exception("tri gia xe khong hop le!");
            }
        }
        public int DungTich
        {
            get { return dungTich; }
            set
            {
                dungTich = value;
                if (dungTich < 0)
                    throw new Exception("dung tich phai lon hon 0");
            }
        }
        public Vehicle()
        {
            this.chuXe = "Nguyen Van A";
            this.loaiXe = "Future";
            this.triGiaXe = 0;
            this.dungTich = 0;
        }
        public Vehicle(string chuXe,string loaiXe,int triGiaXe,int dungTich)
        {
            this.chuXe = chuXe;
            this.loaiXe = loaiXe;
            this.triGiaXe = triGiaXe;
            this.dungTich = dungTich;
        }
        public double thueTB()
        {
            if (dungTich < 100)
                return 0.01 * triGiaXe;
            else if (dungTich < 200)
                return 0.03 * triGiaXe;
            else
                return 0.05 * triGiaXe;
        }
        public void nhapXe()
        {
            Console.Write("Nhap ten chu xe: ");
            ChuXe = Console.ReadLine();
            Console.Write("Nhap loai xe: ");
            LoaiXe = Console.ReadLine();
            Console.Write("Nhap tri gia xe: ");
            TriGiaXe = int.Parse(Console.ReadLine());
            Console.Write("Nhap dung tich xe: ");
            DungTich = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine(string.Format("{0,-24}{1,-25}{2,-15}{3,-18}{4,0}", chuXe, loaiXe, dungTich, triGiaXe, thueTB()));
        }
    }
}
