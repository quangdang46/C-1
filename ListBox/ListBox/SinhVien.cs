﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox
{
    internal class SinhVien
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public override string ToString()
        {
            return this.Ma+" - "+this.Ten;
        }
    }
}
