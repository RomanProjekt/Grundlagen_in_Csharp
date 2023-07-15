using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class CallByReference
    {

        public void Show(ref int val) 
        {
            val *= val;
            Console.WriteLine("Value inside the show function " + val);
        }





    }
}
