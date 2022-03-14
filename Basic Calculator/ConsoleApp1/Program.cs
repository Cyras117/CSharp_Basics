using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Sefining variables
            double result;
            string Ninput,Oinput;
            double number;

            //welcome screen
            Console.Clear();
            Console.WriteLine("\t\tBASIC CALCULATOR\n\n\n");
            Console.WriteLine("\tWelcome!!! Press any key to proceed");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\tInform a number or X to exit:\n\t");
            Ninput = Console.ReadLine().ToLower();
            if (Ninput.Equals("x"))
            {
                Console.WriteLine("\t\tExiting aplication....");
                return;
            }
            result = double.Parse(Ninput);
            while (true)
            {
                Console.WriteLine("\tInform the operation");
                Oinput = Console.ReadLine().ToLower() ;
                if (Oinput.Equals("x"))
                    return;

                Console.WriteLine("\tInform a number or X to exit:\n\t");
                Ninput = Console.ReadLine().ToLower();
                if (Ninput.Equals("x"))
                {
                    Console.WriteLine("\t\tExiting aplication....");
                    break;
                }
                number = double.Parse(Ninput);
                switch (Oinput)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "*":
                        result *= number;
                        break;
                    case "/":
                        result /= number;
                        break;
                    default:
                        Console.WriteLine("invalid operation terminating aplication");
                        return;
                }

                Console.Clear();
                Console.WriteLine("\t\tResult:" + result);
                Console.WriteLine("\n\t\tPress en key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
