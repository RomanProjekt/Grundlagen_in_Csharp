using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class CollectionExample
    {

        public static void setAllCollectionMethoden()
        {

            Console.WriteLine("Hier wird die 1. List ausgegeben!");
            ArrayListTut.setArrayList();

            Console.WriteLine("Hier wird die 2. List ausgegeben!");
            ArrayListTut.setArrayList2();

            Console.WriteLine("Hier wird der Tupel ausgegeben!");
            TupleExample.getTuple();
        }




    }

    public class ArrayListTut
    {
        public static void setArrayList()
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            getAusgabeArrayList(arlist1);

        }

        public static void setArrayList2()
        {
            ArrayList arlist2 = new ArrayList() 
            {
                 12,  "Steve",  " ",  true, 4.5,  null
            };
            getAusgabeArrayList(arlist2);
        }


        public static void getAusgabeArrayList(ArrayList liste)
        {
            foreach (var item in liste)
            {
                if(item != null)
                {
                    Console.WriteLine(item.ToString());
                } else
                {
                    Console.WriteLine("Object ist null!");
                }
                
            }
        }
    }

    public class TupleExample
    {
        public static void getTuple()
        {
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
        }
    }


    public class DictonaryExample
    {
        public static void getDictonary()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
        }


        
    }


}
