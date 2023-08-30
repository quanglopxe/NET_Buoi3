using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo td = new ToaDo();
            Console.Write("Nhap ten toa do: ");
            td.Ten = Console.ReadLine();
            Console.Write("Nhap toa do x: ");
            td.X = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            td.Y = int.Parse(Console.ReadLine());
            td.toString();
            Console.ReadLine();
        }
    }
}
