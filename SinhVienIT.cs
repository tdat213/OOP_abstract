using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_abstract
{
    public class SinhVienIT : SinhVien
    {
        public double diemJava;
        public double diemCss;
        public override double diemTB()
        {
            return (2 * diemJava + diemCss) / 3;
        }


    }
}
