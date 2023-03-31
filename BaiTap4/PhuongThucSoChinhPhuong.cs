using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    public class PhuongThucSoChinhPhuong
    {
        public static bool  soCP(int n)
        {
            int kiemTra = (int)Math.Sqrt(n);

            if (kiemTra * kiemTra==0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
