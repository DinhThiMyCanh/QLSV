using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    abstract class SinhVien
    {
        protected int maSV;
        private string hoTen;//Ctrl+R+E

        public string HoTen { get => hoTen; set => hoTen = value; }

        public SinhVien()
        {
            this.maSV = 0;
            this.HoTen = "";
        }
        public SinhVien(int maSV, string hoTen)
        {
            this.maSV = maSV;
            this.HoTen = hoTen;
        }

        //Nhap thong tin Sinh Vien
        public virtual void nhap()
        {
            Console.WriteLine("Nhap ma SV:");
            maSV =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ho ten:");
            HoTen = Console.ReadLine();
        }
        //Tinh diem trung binh
        abstract public float tinhDTB();

        //Xac dinh loai sinh vien
        public virtual string loaiSV()
        {
            return "";
        }
        

    }
}
