using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class UserInputExample
    {

        public static void eingabeUserInput()
        {
            Console.WriteLine("Gib deinen Namen ein:");
            String? namen = Console.ReadLine();

            int? jNullable = 42;


            Console.WriteLine(namen);
        }
    }
}
