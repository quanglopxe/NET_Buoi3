using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai3
{
    class HinhTamGiac
    {
        private int mA, mB, mC;

        public int MC
        {
            get { return mC; }
            set { mC = value;
            if (mC < 0)
                throw new Exception("gia tri phai lon hon 0");
            }
        }

        public int MB
        {
            get { return mB; }
            set { mB = value;
            if (mB < 0)
                throw new Exception("gia tri phai lon hon 0");
            }
        }

        public int MA
        {
            get { return mA; }
            set { mA = value;
            if (mA < 0)
                throw new Exception("gia tri phai lon hon 0");
            }
        }
        public HinhTamGiac()
        {
            this.mA = 2;
            this.mB = 5;
            this.mC = 4;
        }
        public HinhTamGiac(int mA, int mB, int mC)
        {
            if (mA > 0 && mB > 0 && mC > 0 && (mA + mB) > mC && (mC + mB) > mA && (mA + mC) > mB)
            {
                this.mA = mA;
                this.mB = mB;
                this.mC = mC;
            }
            else
            {
                this.mA = 0;
                this.mB = 0; 
                this.mC = 0;
            }
            
            
            
        }
        public int tinhChuVi()
        {
            return mA + mB + mC;
        }
        public double tinhDienTich()
        {
            double p = tinhChuVi() / 2;
            return Math.Sqrt(p * (p - mA) * (p - mB) * (p - mC));
        }
        public string loaiTamGiac()
        {
            if (mA == 0 && mB == 0 && mC == 0)
                return "Khong phai tam giac";
            else if (mA == mB && mA == mC)
                return "Tam giac deu";
            else if (mA == mB || mB == mC || mC == mA)
                return "Tam giac can";
            else
                return "Tam giac thuong";
        }
        public void toString()
        {
            Console.Write("mA: {0}\tmB: {1}\tmC: {2}", mA, mB, mC);
            Console.Write("\nLoai tam giac: {0}", loaiTamGiac());
            Console.Write("\nChu vi: {0}", tinhChuVi());
            Console.Write("\nDien tich: {0}", tinhDienTich());
        }
    }
}
