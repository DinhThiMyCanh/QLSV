using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLSV
{
    class DSSV
    {
        private ArrayList list;

        public DSSV()
        {
            list = new ArrayList();
        }

        public void them(SinhVien sv)
        {
            list.Add(sv);
        }
        public void hienThi()
        {
            foreach (SinhVien sv in list)
            {
                Console.Write("Ho ten:{0} ", sv.HoTen);
                Console.Write("Chuyen nganh:{0} ", sv.loaiSV());
                Console.Write("Diem TB:{0} ", sv.tinhDTB());
                Console.WriteLine();
            }    
        }
    }
}
