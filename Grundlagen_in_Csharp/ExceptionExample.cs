using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class ExceptionExample
    {
        

        public static void division() 
        {

            double i = 2;
            double j = 0;
            double ergebnis = 0;

            try
            {
                ergebnis = i / j;
                Console.WriteLine(ergebnis);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excpetion geworfen!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            } 
            finally {
                Console.WriteLine("Finalle End!");
            }
        }
    }

    public class MeineFehler : Exception
    {
        string fehlermeldung;

        public MeineFehler()
        {
            fehlermeldung = "Standard Fehlermeldung";
        }

        public MeineFehler(string? message) : base(message)
        {
            new MeineFehler();
            this.fehlermeldung = message;
        }

        
    }


}
