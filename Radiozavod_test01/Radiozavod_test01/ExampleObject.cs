using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiozavod_test01
{
    public class ExampleObject : OnAir, Military
    {
        private int radiusBattle;

        public ExampleObject(int high) : base(high){}

        override public void Show()
        {
            Console.Write(high);
        }

        public int RadiusBattle  
        {
            get { return radiusBattle;  }
            set { radiusBattle = value; }
        }
    }
}
