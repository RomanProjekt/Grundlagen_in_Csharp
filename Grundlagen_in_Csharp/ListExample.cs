using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class ListExample
    {

        List<string> stringList = new List<string>();


        public void start()
        {
            stringList.Add("Thomas Maier");
            stringList.Add("Franz Huber");
            stringList.Add("Ermin Prot");

            this.ausgabeList(stringList);
        }


        public void ausgabeList(List<string> namesListe)  { 
        

            for (int i = 0; i < namesListe.Count; i++)
            {
                string s = namesListe[i];
                System.Console.WriteLine(s);
            }
        
        }

      

    }
}
