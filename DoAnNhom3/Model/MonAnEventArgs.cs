using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom3.Model
{
    public class MonAnEventArgs : EventArgs
    {
        public string TenMon { get; set; }
        public decimal GiaTien { get; set; }
        public Image HinhAnh { get; set; }
    }
}
