using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HomeTasks.Controller
{
    internal class CalgulaterController
    {
        public void Calculate()
        //        {
        //            Console.WriteLine("Add number:");
        //            decimal num1 = Convert.ToDecimal(Console.ReadLine());


        //            Console.WriteLine("Add operation: (+,_,*,/)");
        //            string operation = Console.ReadLine();

        //            Console.WriteLine("Add number:");
        //            decimal num2 = Convert.ToDecimal(Console.ReadLine());

        //            Calgulator calculator = new();
        //            calculator.Calgulate(num1, operation, num2);
        //        }
        //    }
        //}

        //        {
        //            string[] operations = { "*", "/", "-", "+" };

        //            Console.WriteLine("Add number:");
        //            decimal num1 = Convert.ToDecimal(Console.ReadLine());


        //            Console.WriteLine("Add operation: (+,_,*,/)");
        //        Operation: string operation = Console.ReadLine();

        //            if (operation == "/" || operation == "*" || operation == "+" || operation == "-")
        //            {

        //                Console.WriteLine("Add number:");
        //            Num2: decimal num2 = Convert.ToDecimal(Console.ReadLine());


        //                if (operation == "/" && num2 == 0)
        //                {
        //                    Console.WriteLine("Can't divide to zero, pls add second number again");
        //                    goto Num2;
        //                }

        //                Calgulator calculator = new();
        //                calculator.Calgulate(num1, operation, num2);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Your operation is wrong, pls add correct operation:");
        //                goto Operation;
        //            }
        //        }
        //    }
        //}

        {
            string[] operations = { "*", "/", "-", "+" };

            Console.WriteLine("Add number:");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Add operation: (+,_,*,/)");
        Operation: string operation = Console.ReadLine();

            if (operations.Contains(operation))

            if (operation == "/" || operation == "*" || operation == "+" || operation == "-")
            {

                Console.WriteLine("Add number:");
            Num2: decimal num2 = Convert.ToDecimal(Console.ReadLine());


                if (operation == "/" && num2 == 0)
                {
                    Console.WriteLine("Can't divide to zero, pls add second number again");
                    goto Num2;
                }

                Calgulator calculator = new();
                calculator.Calgulate(num1, operation, num2);
            }
            else
            {
                Console.WriteLine("Your operation is wrong, pls add correct operation:");
                goto Operation;
            }
        }
    }
}















