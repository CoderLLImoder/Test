using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiozavod_test01
{
    public abstract class OnAir
    {
        protected string Type = "Air";
        protected int high;

        public OnAir(int high) { this.high = high; }
        public abstract void Show();
    }
}
