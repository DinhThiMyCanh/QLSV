using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SV_Van:SinhVien
    {
        private float coDien;
        private float hienDai;

        public SV_Van():base()
        {
            this.coDien = 0.0f;
            this.hienDai = 0.0f;
        }
        public SV_Van(int maSV, string hoTen, float coDien, float hienDai):base(maSV,hoTen)
        {
            this.coDien = coDien;
            this.hienDai = hienDai;

        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap van hoc co dien:");
            coDien = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap van hoc hien dai:");
            hienDai = float.Parse(Console.ReadLine());
        }

        public override float tinhDTB()
        {
            return (float)((coDien + hienDai) / 2);
        }
        public override string loaiSV()
        {
            return "Van";
        }

    }
}
