using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {

            HangThucPham hang1 = new HangThucPham("001","Gao",100000,new DateTime(2018,7,10),new DateTime(2018,7,10));
            HangThucPham hang2 = new HangThucPham("002", "Mi", 5000, new DateTime(2018, 3, 1), new DateTime(2018, 9, 1));
            HangThucPham hang3 = new HangThucPham("003", "Nuoc", 10000, new DateTime(2017, 3, 1), new DateTime(2018, 3, 1));

            Console.Write("Ma_Hang\t\tTen_Hang\tDon_Gia\t\tNgay_San_Xuat\t\tNgay_Het_Han\t\tGhi_Chu");
            Console.Write("\n-----------------------------------------------------------------------------------------------------");
            hang1.toString();
            hang2.toString();
            hang3.toString();
            Console.ReadLine();
        }
    }
}
