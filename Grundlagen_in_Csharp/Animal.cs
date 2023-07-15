using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class Animal
    {
        public virtual void eat() 
        {
            Console.WriteLine("Eating.... - Animal");
        }

        public virtual void laufen()
        {
            Console.WriteLine("Laufen.... - Animal");
        }


    }

    internal class Dog:Animal { 

        public override void eat()
        {
            Console.WriteLine("Eating bread - Dog");
        }
    
    }

    internal class Dog2 :Dog
    {

    }

    //1. Dog , override und kein virutal (Animal) -> Fehler
    //2. Dog , kein override und virtuel (Animal) -> nimmt die Methode aus Dog -> eat()
    //3. Dog , override und virutell (Animal) -> nimmt die Methode aus Dog -> eat()
   


   

}
