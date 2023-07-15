using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class LamdaExample
    {


        public static void getStatement1()
        {
            var square = (int num) => num * num;
            Console.WriteLine("Square of number:" + square(5));
        }

    }
}
