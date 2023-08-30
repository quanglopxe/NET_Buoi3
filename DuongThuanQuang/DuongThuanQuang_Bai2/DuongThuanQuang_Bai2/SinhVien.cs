using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai2
{
    class SinhVien
    {
        private int maSV;
        private string hoTen;
        private double diemLT, diemTH;
        public int MaSV
        {
            get { return maSV; }
            set
            {
                maSV = value;
                if (maSV < 0)
                    throw new Exception("Ma sv phai > 0");
            }
        }
        public string HoTen
        {
            get { return hoTen; }
            set {
                    hoTen = value; 
                    if(hoTen==null)
                        throw new Exception("Ho ten khong duoc rong");
                }
        }
        public double DiemLT
        {
            get { return diemLT; }
            set
            {
                diemLT = value;
                if (diemLT < 0.0 || diemLT > 10.0)
                    throw new Exception("Diem ko hop le");
            }
        }
        public double DiemTH
        {
            get { return diemTH; }
            set
            {
                diemTH = value;
                if (diemTH < 0.0 || diemTH > 10.0)
                    throw new Exception("Diem ko hop le");
            }
        }
        public SinhVien()
        {
            this.maSV = 2001216070;
            this.hoTen = "Duong Thuan Quang (default)";
            this.diemLT = 8.7;
            this.diemTH = 9.5;
        }
        public SinhVien(int maSV, string hoTen, double diemLT, double diemTH)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        }
        public double tinhDTB()
        {
            return (diemLT + diemTH) / 2;
        }
        public void toString()
        {
            Console.Write(string.Format("\n{0,-20}{1,-30}{2,-15}{3,-15}{4,0}",maSV,hoTen,diemLT,diemTH,tinhDTB()));
        }
    }
}
