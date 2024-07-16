using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SV_CNTT:SinhVien
    {
        private float pasCal;
        private float c_Sharp;
        private float SQL;

        public SV_CNTT():base()
        {
            this.pasCal = 0.0f;
            this.c_Sharp = 0.0f;
            this.SQL = 0.0f;
        }
        public SV_CNTT(int maSV, string hoTen, float pasCal, float c_Sharp, float SQL): base(maSV,hoTen)
        {
            this.pasCal = pasCal;
            this.c_Sharp = c_Sharp;
            this.SQL = SQL;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap diem pasCal:");
            pasCal =float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem c_Sharp:");
            c_Sharp = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem SQL:");
            SQL = float.Parse(Console.ReadLine());
        }

        public override float tinhDTB()
        {
            return (float)((pasCal + c_Sharp + SQL)/3);
        }
        public override string loaiSV()
        {
            return "CNTT";
        }
    }
}
