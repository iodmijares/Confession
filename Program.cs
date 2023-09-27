using System;
using System.Data.SqlClient; 
using System.Threading;

namespace Practice01 
{ 
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Single? (y/n) ");
            string ask = Console.ReadLine();

            if (ask == "n"){
                Console.WriteLine("You have someone you love? (y/n)");
                string ask2 = Console.ReadLine();
                if (ask2 == "n")
                {
                    Console.WriteLine("nice!");
                    Thread.Sleep(3000);
                    Console.WriteLine("ano kasi");
                    Thread.Sleep(3000);
                    Console.WriteLine("kanang");
                    Thread.Sleep(3000);
                    Console.WriteLine("gusto abi taka!");
                    Thread.Sleep(1000);
                    Console.WriteLine("<3");
                }
                else
                {
                    Console.WriteLine("dapat wala");
                    Thread.Sleep(3000);
                    Console.WriteLine("kasi ano");
                    Thread.Sleep(1000);
                    Console.WriteLine("Naa rako like ");
                    Thread.Sleep(3000);
                    Console.WriteLine("NIMO");
                    Thread.Sleep(5000);
                    Console.WriteLine("isay pero sige di nalang");
               } 
            }
            else if (ask == "y") 
            {
                Console.WriteLine("ayy sige");
                Thread.Sleep(1000);
                Console.WriteLine("naa ra unta ko gusto");
                Thread.Sleep(3000);
                Console.WriteLine("NIMO");
                Thread.Sleep(5000);
                Console.WriteLine("iingon pero sige di nalang");
                Console.WriteLine("BYE!!");
            }
            else
            {
                Console.WriteLine("Dapat gamay na 'y' kag gamay na 'n' ra ibutang tas dapat y kag n ra itype");
            }
        }
    }
}

