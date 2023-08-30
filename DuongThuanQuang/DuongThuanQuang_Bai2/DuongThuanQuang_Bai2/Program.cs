using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien(1111, "Duong Thuan Quang", 7.8, 8.6);
            SinhVien sv2 = new SinhVien(2222, "Nguyen Tu Thanh Dat", 8.7, 8.9);
            SinhVien sv3 = new SinhVien();
            Console.Write("Nhap ma sv: ");
            sv3.MaSV = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho va ten: ");
            sv3.HoTen = Console.ReadLine();
            Console.Write("Nhap diem ly thuyet: ");
            sv3.DiemLT = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem thuc hanh: ");
            sv3.DiemTH = double.Parse(Console.ReadLine());
            Console.Write("Ma SV\t\t\tHo ten\t\t\tDiem Ly thuyet\tDiem thuc hanh\tDiem trung binh");
            sv1.toString();
            sv2.toString();
            sv3.toString();
            Console.ReadLine();
        }
    }
}
