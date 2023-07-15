using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class OperatorenOverloading
    {
        private int x;
        private int y;

        public OperatorenOverloading()
        {
        }

        public OperatorenOverloading(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowXY()
        {
            Console.WriteLine("{0}{1}", x, y);
        }

        public static OperatorenOverloading operator -(OperatorenOverloading c)
        {
            OperatorenOverloading temp = new OperatorenOverloading();
            temp.x = -c.x;
            temp.y = -c.y;
            return temp;
        }



    }
}
