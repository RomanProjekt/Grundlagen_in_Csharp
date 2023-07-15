using System.Collections;

namespace Grundlagen_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dalmadiner dali = new Dalmadiner(1, "Fiffi", 12, 12);
            dali.gehen();

            Dalmadiner fonzo = new Dalmadiner(2);
            fonzo.Name = "Fonzo";
            fonzo.Age = 12;
            fonzo.Breite = 141;

            System.Console.WriteLine(fonzo.Id);
            System.Console.WriteLine(fonzo.Name);
            System.Console.WriteLine(fonzo.Age);
            System.Console.WriteLine(fonzo.Breite);

            Tut01 tut01 = new Tut01();
            tut01.start();


            Console.WriteLine("----------------------------------");
            Dog d = new Dog();
            d.eat();

            Console.WriteLine("----------------------------------");
            Dog2 d2 = new Dog2();
            d2.laufen();

            Console.WriteLine("----------------------------------");

            int val = 50;
            Console.WriteLine("Value before calling the function " + val);
            CallByReference cbr = new CallByReference();
            cbr.Show(ref val);
            Console.WriteLine("Value after calling the function " + val);


            Console.WriteLine("----------------------------------");

            Console.WriteLine(EnumExample.getMännlich());

            Console.WriteLine("----------------------------------");

            OverloadingExample.PlusMethodInt(12, 12);
            //OverloadingExample.PlusMethodDouble(12,12); 

            Console.WriteLine("----------------------------------");

            ExceptionExample.division();

            Console.WriteLine("----------------------------------");

            ForEachExample.getArrayName();

            Console.WriteLine("----------------------------------");

            CollectionExample.setAllCollectionMethoden();

            Console.WriteLine("----------------------------------");

            LamdaExample.getStatement1();

            ArrayList list = new ArrayList();

            for (int i = 0; i < list.Count; i++)
            {
                list.Add(list[i]);
            }


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ordner Hello World!");
            HelloWorld helloworld = new HelloWorld();
            helloworld.getHelloWorld();



        }
    }


    public class Hund : HundeInterface, IKatzenInterface
    {
        private int id;

        public Hund(int id)
        {
            this.id = id;
        }

        public string miau()
        {
            return "Katze macht miau!";
        }

        public int multiplizeren()
        {
            return 0;
        }

        public int multiplizeren(int a, int b)
        {
            return a * b;
        }

        public int summe(int a, int b)
        {
            return a + b;
        }
    }

    public class Dalmadiner : Hund
    {

        private int id;
        private string name;
        private int age;
        private int breite;

        public Dalmadiner(int id) : base(id)
        {
            if (id != 0)
            {
                this.id = id;
            }
            else
            {
                this.id = id++;
            }


        }

        public Dalmadiner(int id, string name, int age, int breite) : base(id)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.breite = breite;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Id { get; set; }


        public int Breite { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }

        public void gehen(int richtung = 1)
        {
            if (richtung == 1)
            {
                Console.WriteLine("Der Hund läuft in die Richtung!");
            }
            lautvonSichGeben();
        }

        public void lautvonSichGeben()
        {
            Console.WriteLine("Wuff");
        }
    }
    
}

public class FritzHund : Abstraktklasse.AbstraktKlasse
{

}