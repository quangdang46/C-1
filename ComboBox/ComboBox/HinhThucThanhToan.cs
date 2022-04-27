using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    internal class HinhThucThanhToan
    {
        public int Ma { get; set; }
        public string Hinhthucthanhtoan { get; set; }
        public int Phithanhtoan { get; set; }
        public override string ToString()
        {
            return this.Hinhthucthanhtoan;
        }
    }
}
