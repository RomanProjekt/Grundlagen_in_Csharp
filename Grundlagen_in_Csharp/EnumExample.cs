using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    public class EnumExample
    {

        enum Geschlecht { männlich, weiblich, neutral};

        public static String getMännlich()
        {
            return Geschlecht.männlich.ToString();
        }



    }
}
