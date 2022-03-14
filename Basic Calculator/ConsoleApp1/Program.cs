using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sefining variables
            double result=0,previousResult;
            bool loopControl = true;
            string Ninput,Oinput;
            double number, suportNumber;

            //welcome screen
            Console.Clear();
            Console.WriteLine("\t\tBASIC CALCULATOR\n\n\n");
            Console.WriteLine("\tWelcome!!! Press any key to proceed");
            Console.ReadKey();

            //entering loop
            //todo: Refactor this to be simplier.
            while (loopControl)
            {
                //basic menu set up
                Console.Clear();
                //todo:Check this
                Console.WriteLine("\t\tBasic Calculator\n\n\tTo exit type X\n\n\tPrevious Result:"+previousResult+"\n\n\tInform the number:");
                // geting number Ninput
                Ninput = Console.ReadLine().ToLower();
                //Checking exit condition
                if(Ninput.Equals("x"))
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\t\tClosing calculator!!!\n\nPress any ky to close.");
                    Console.ReadKey();
                    break;
                }
                //Parsing Ninput to number
                number = double.Parse(Ninput);
                //todo:Check this.
                previousResult = number;

                //second loop
                while (loopControl)
                {
                    // Geting operation Oinput
                    Console.WriteLine("\tInform the operation:\n+ For addition\n- Subtraction\n* Mutiplication\n / Division");
                    Oinput = Console.ReadLine().ToLower();

                    //Checking if it is a valid operation
                    if (!(Oinput.Equals("*") || Oinput.Equals("/") || Oinput.Equals("+") || Oinput.Equals("-")))
                    {
                        Console.Clear();
                        Console.WriteLine("\t\tInvalid operation, exiting program!!!");
                        Console.WriteLine("\tlast Valid result:\t" + previousResult);
                        Console.WriteLine("Press any key to proceed");
                        Console.ReadKey();
                    }
                    //Getting number Ninput
                    Console.WriteLine("\tInform the number or X to exit");
                    Ninput = Console.ReadLine().ToLower();
                     //Checking exit condition
                    if(Ninput.Equals("x"))
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\t\tClosing calculator!!!\n\nPress any ky to close.");
                        Console.ReadKey();
                        break;
                    }
                    //Parsing Ninput to number
                    number = double.Parse(Ninput);
                    previousResult = number;
                    //Checking exit condition
                    if (Ninput.Equals("x"))
                    {
                        Console.Clear();
                        Console.WriteLine("Last Result:\t", result);
                        Console.WriteLine("\n\n\t\tClosing calculator!!!\n\nPress any ky to close.");
                        Console.ReadKey();
                        break;
                    }
                    //Parsing Ninput to number
                    number = double.Parse(Ninput);
                    previousResult = number;

                }
            }
            
            Console.ReadKey();//temporary -> Just ignore it.

        }
    }
}
