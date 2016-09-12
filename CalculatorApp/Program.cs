using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool operation = true;
            while (operation)
            {



                Console.Clear();
                Console.WriteLine("Calculator App By: 3 mands gruppen.");

                Console.WriteLine("Choose an action. Follwed by Enter.\n");
                Console.WriteLine("Add          : 1 \n"
                                 + "Subtract     : 2\n"
                                 + "Multiply     : 3\n"
                                 + "Divide       : 4\n"               
                                 + "Power        : 5\n"
                                 + "Factorial    : 6 \n"
                                 + "Exit program : 7");
                string act = Console.ReadLine();
                Console.Clear();


                int value1 = 0;
                int value2 = 0;


                switch (act)
                {

                    case "1":

                        try
                        {
                            Console.WriteLine("Enter your first value: followed by Enter.");
                            value1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your second value: followed by Enter.");
                            value2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The solution is :" + Calculator.Add(value1, value2));
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid value!");
                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        try
                        {


                            Console.WriteLine("Enter your first value: followed by Enter.");
                            value1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your second value: followed by Enter.");
                            value2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("The solution is :" + Calculator.Subtract(value1, value2));
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid value!");
                            Console.ReadKey();
                        }

                        break;

                    case "3":
                        try
                        {


                            Console.WriteLine("Enter your first value: followed by Enter.");
                            value1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your second value: followed by Enter.");
                            value2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("The solution is :" + Calculator.Multy(value1, value2));
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid value!");
                            Console.ReadKey();

                        }

                        break;

                    case "4":
                        try
                        {


                            Console.WriteLine("Enter your first value: followed by Enter.");
                            value1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your second value: followed by Enter.");
                            value2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("The solution is :" + Calculator.Div(value1, value2));
                            Console.ReadKey();
                            
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid value!");
                            Console.ReadKey();

                        }

                        break;


                    case "5":
                        try
                        {


                            Console.WriteLine("Enter your first value: followed by Enter.");
                            value1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your second value: followed by Enter.");
                            value2 = Convert.ToInt32(Console.ReadLine());


                            Console.WriteLine("The solution is :" + Calculator.Power(value1, value2));
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid value!");
                            Console.ReadKey();

                        }

                        break;

                    case "6":
                        try
                        {


                            Console.WriteLine("Enter your value: followed by Enter.");
                            value1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The solution is :" + Calculator.Fac(value1));
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("Not a valid value!");
                            Console.ReadKey();


                        }

                        break;

                    case "7":
                        try
                        {


                            Console.WriteLine("End of operation");
                            operation = false;
                            Console.ReadKey();
                        }
                        catch
                        {
                            
                          
                        }
                        break;


                    default:
                        Console.WriteLine("You have to enter an invalid option!");
                        Console.ReadKey();
                        break;


                }
            }
        }

    }
}
