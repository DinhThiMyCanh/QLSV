using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            DSSV list = new DSSV();
            SinhVien sv;
            int chon;
            string tieptuc = "";
            do
            {
                Console.WriteLine("Nhap sv:(1_SVCNTT,2_SVVan):");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sv = new SV_CNTT();
                        sv.nhap();
                        list.them(sv);
                        break;
                    case 2:
                        sv = new SV_Van();
                        sv.nhap();
                        list.them(sv);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("ban co muon tiep tuc khong?(Y/N");
                tieptuc = Console.ReadLine();
            } while (tieptuc == "Y");

            list.hienThi();
            Console.ReadKey();
        }
    }
}
