using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai5
{
    class HangThucPham
    {
        private string maHang;
        private string tenHang;
        private int donGia;
        private DateTime ngaySanXuat;
        private DateTime ngayHetHan;
        public string MaHang
        {
            get { return maHang; }
        }
        public string TenHang
        {
            get { return tenHang; }
            set
            {
                tenHang = string.IsNullOrEmpty(value) ? "xxx" : value;
            }
        }
        public int DonGia
        {
            get { return donGia; }
            set
            {
                donGia = value >= 0 ? value : 0;
            }
        }
        public DateTime NgaySanXuat
        {
            get { return ngaySanXuat; }
            set
            {
                ngaySanXuat = value <= DateTime.Now ? value : DateTime.Now;
            }
        }
        public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set
            {
                ngayHetHan = value > ngaySanXuat ? value : ngaySanXuat;
            }
        }
        public HangThucPham(string maHang, string tenHang,int donGia, DateTime ngaySanXuat, DateTime ngayHetHan)
        {
            if (string.IsNullOrEmpty(maHang))
                throw new Exception("Ma hang khong duoc rong");
            this.maHang = maHang;
            this.tenHang = string.IsNullOrEmpty(tenHang) ? "xxx" : tenHang; ;
            this.donGia = donGia >= 0 ? donGia : 0;
            this.ngaySanXuat = ngaySanXuat <= DateTime.Now ? ngaySanXuat : DateTime.Now;
            this.ngayHetHan = ngayHetHan > ngaySanXuat ? ngayHetHan : ngaySanXuat;
        }
        public HangThucPham(string maHang)
            : this(maHang,"xxx",0,DateTime.Now,DateTime.Now)
        { }
        public string isHetHan()
        {
            if (ngayHetHan < DateTime.Now)
                return "Da het han!";
            else
                return "Chua het han";
        }
        public void toString()
        {
            var separator= new System.Globalization.NumberFormatInfo() 
            {
            NumberDecimalDigits = 0,
            NumberGroupSeparator = "."
            };
            string formattedDonGia = donGia.ToString("N",separator);
            string formattedNgaySanXuat = ngaySanXuat.ToString("dd/MM/yyyy");
            string formattedNgayHetHan = ngayHetHan.ToString("dd/MM/yyyy");
            Console.Write(string.Format("\n{0,-16}{1,-16}{2,-16}{3,-24}{4,-20}{5,0}", maHang, tenHang, formattedDonGia, formattedNgaySanXuat, formattedNgayHetHan, isHetHan()));
        }
    }
}
