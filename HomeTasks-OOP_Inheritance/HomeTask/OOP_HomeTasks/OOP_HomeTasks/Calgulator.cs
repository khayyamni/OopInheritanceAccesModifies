using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HomeTasks
{
    internal class Calgulator
    {
        public void Calgulate(decimal num1, string operation, decimal num2)
        {
            decimal result;
            //if(operation == "/" && num2 == 0)
            //{
            //    Console.WriteLine("Can't divide to zero");
            //    return;
            //}

            switch(operation)
            {
                case "+":
                      result = num1 +num2;
                    Console.WriteLine("Result: " + result);
       

                    break;       
                
                case "-":
                      result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                    break;


            }
        }
    }
}
