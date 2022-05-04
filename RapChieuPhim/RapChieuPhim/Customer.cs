using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhim
{
    public class Customer
    {
        public String Name { get; set; }
        public String Phone { get; set; }
        public List<int> ghes{get;set;}
        public Customer()
        {
            ghes = new List<int>();
        }
        public int TinhTien
        {
            get
            {
                return ghes.Count * 100000;
            }
        }
        public override String ToString()
        {
            return this.Name+"-"+this.Phone;
        }
    }
}
