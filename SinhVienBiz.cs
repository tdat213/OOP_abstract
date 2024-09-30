using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_abstract
{
    public class SinhVienBiz : SinhVien
    {
        public double keToan;
        public double marketting;
        public double banHang;
        public override double diemTB()
        {
            return (keToan+ marketting + banHang) / 3;
        }

    }
}
