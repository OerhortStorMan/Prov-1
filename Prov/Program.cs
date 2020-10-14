using System;
using System.Threading;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            //eftersom man ska kunna köpa o sälja böcker så kör jag två separata metoder för spelet
            System.Console.WriteLine("Välkommen till antikspelet, du spelar som en manager för bokavdelningen");
            Buying();

        }

        static void Buying()
        {
            bool gameIsRunning = true;
            while (gameIsRunning)
            {
                System.Console.WriteLine("Här är tre böcker:");

                Books b1 = new Books();
                b1.Book();
                b1.PrintInfo();
                System.Console.WriteLine();
                Thread.Sleep(1500);

                Books b2 = new Books();
                b2.Book();
                b2.PrintInfo();
                System.Console.WriteLine();
                Thread.Sleep(1500);
                
                Books b3 = new Books();
                b3.Book();
                b3.PrintInfo();
                System.Console.WriteLine();

                System.Console.WriteLine("Vilken vill du ta en närmare titt på?");
                string input = Console.ReadLine();

                

            }
        }

        static void Selling()
        {
            bool currentlySelling = true;
            while (currentlySelling)
            {

            }

        }

    }
}
