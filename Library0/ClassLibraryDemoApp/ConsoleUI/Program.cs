using System;
//using FrameworkLibrary;
//using CoreLibrary;
using StandardLibrary;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {

            //var autoEvent = new AutoResetEvent(false);


            //MethodGenerators genThis = new MethodGenerators();
            //PersonaListModel primePerson = new PersonaListModel
            //{
            //    Prefix = "Madame",
            //    fName = "Yukari",
            //    lName = "Yakumo"
            //};

            //List<string> msg = new List<string>();
            //msg.Add(genThis.Hello(primePerson.Prefix, primePerson.lName));


            //msg.ForEach(delegate (String name)
            //{
            //    Console.WriteLine(name);
            //});

            //void Print(string s)
            //{
            //    Console.WriteLine(s);
            //}

            var count = 0;

            TimeSpan Delay0 = TimeSpan.FromTicks(10000);

            TimeSpan Delay1 = TimeSpan.FromTicks(5000);

            TimeSpan interval0 = TimeSpan.FromTicks(1500);

            TimeSpan interval1 = TimeSpan.FromTicks(3000);

            Action Printing0 = new Action(PrintHello);

            Action Printing1 = new Action(PrintGbye);

            while (count < 17)
            {
                At.Do(Printing0, Delay1, interval1, null);

                At.Do(Printing1, Delay0, interval0, null);

                count++;
            }
            Console.ReadLine();

            static void PrintHello()
            {

                MethodGenerators genThis = new MethodGenerators();
                PersonaListModel primePerson = new PersonaListModel
                {
                    Prefix = "Madame",
                    fName = "Yukari",
                    lName = "Yakumo"
                };

                Console.WriteLine(genThis.Hello(primePerson.Prefix, primePerson.lName));
            }

            static void PrintGbye()
            {

                MethodGenerators genThis = new MethodGenerators();
                PersonaListModel primePerson = new PersonaListModel
                {
                    Prefix = "Madame",
                    fName = "Yukari",
                    lName = "Yakumo"
                };

                Console.WriteLine(genThis.Adios(primePerson.Prefix, primePerson.lName));
            }
        }
    }
}
