using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle xe1 = new Vehicle("Nguyen Thu Loan","Future Neo",35000000,100);
            Vehicle xe2 = new Vehicle("Le Minh Tinh", "Ford Ranger", 250000000, 3000);
            Vehicle xe3 = new Vehicle("Nguyen Minh Triet", "Landscape", 1000000000, 1500);
            //xe1.nhapXe();
            Console.Write("Ten chu xe\t\tLoai xe\t\t\tDung tich\tTri gia\t\tThue phai nop");
            Console.Write("\n=======================================================================================================\n");
            xe1.xuat();
            xe2.xuat();
            xe3.xuat();
            Console.ReadLine();
        }
    }
}
