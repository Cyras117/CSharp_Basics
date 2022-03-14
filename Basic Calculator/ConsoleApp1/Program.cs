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

            // get the first number
            Console.WriteLine("\tInform a number or X to exit:\n\t");
            Ninput = Console.ReadLine().ToLower();
            //check exit condition
            if (Ninput.Equals("x"))
            {
                Console.WriteLine("\t\tExiting aplication....");
                return;
            }
            //Parsing to double
            //todo:Check if it is not a invalid char
            result = double.Parse(Ninput);
            //main loop
            while (true)
            {
                //get the operation type
                Console.WriteLine("\tInform the operation or X to exit");
                Oinput = Console.ReadLine().ToLower() ;
                //check exit condition
                if (Oinput.Equals("x"))
                    return;
                
                //get second number
                Console.WriteLine("\tInform a number or X to exit:\n\t");
                Ninput = Console.ReadLine().ToLower();
                //check exit condition
                if (Ninput.Equals("x"))
                {
                    Console.WriteLine("\t\tExiting aplication....");
                    break;
                }
                //Parsing to double
                //todo:Check if it is not a invalid char
                number = double.Parse(Ninput);
                //executing the operations
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
                    //In case it is not a valid operation
                    default:
                        Console.WriteLine("invalid operation terminating aplication");
                        return;
                }
                //showing the result
                Console.Clear();
                Console.WriteLine("\t\tResult:" + result);
                Console.WriteLine("\n\t\tPress en key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
