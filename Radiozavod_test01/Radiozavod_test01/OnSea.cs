using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiozavod_test01
{
    public abstract class OnSea
    {
        protected string Type = "Sea";
        protected int displace;

        public OnSea(int displace) { this.displace = displace; }
        public abstract void Show();
    }
}
