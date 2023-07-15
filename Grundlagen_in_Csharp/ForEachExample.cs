using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class ForEachExample
    {
        public static string[] names = new string[3] { "Suresh Dasari", "Rohini Alavala", "Trishika Dasari" };
        
        public static void getArrayName()
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-------------------");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
       

}
}
