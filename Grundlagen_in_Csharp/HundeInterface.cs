using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal interface HundeInterface
    {

        int multiplizeren(int a, int b);

        int summe(int a, int b);
    }


    internal interface IKatzenInterface 
    {
        string miau();
    } 
}
