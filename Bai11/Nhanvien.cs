using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuần5.Bai11
{
    public class Nhanvien
    {
        private string maNV;
        private string hoTen;
        private int namSinh;
        private string gioiTinh;
        private string diaChi;

        public Nhanvien(string maNV, string hoTen, int namSinh,  string diaChi, string gioiTinh)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
        }

        public string MaNV
        {
            get { return this.maNV; }
            set { this.maNV = value; }
        }

        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }
        public string GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }

        public int NamSinh
        {
            get { return this.namSinh; }
            set { this.namSinh = value; }
        }
    }
}