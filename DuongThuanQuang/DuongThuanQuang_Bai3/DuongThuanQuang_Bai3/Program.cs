using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTamGiac hinh1 = new HinhTamGiac(2, 1, 1);

            HinhTamGiac hinh2 = new HinhTamGiac(1, 2, 5);

            HinhTamGiac hinh3 = new HinhTamGiac(3, 3, 3);

            HinhTamGiac hinh4 = new HinhTamGiac(2, 4, 5);

            HinhTamGiac hinh5 = new HinhTamGiac(3, 3, 5);

            Console.Write("Hinh 1: ");
            hinh1.toString();
            Console.Write("\n\nHinh 2: ");
            hinh2.toString();
            Console.Write("\n\nHinh 3: ");
            hinh3.toString();
            Console.Write("\n\nHinh 4: ");
            hinh4.toString();
            Console.Write("\n\nHinh 5: ");
            hinh5.toString();

            Console.ReadLine();
        }
    }
}
