using MethodClassTask;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;



namespace MethodClassTask
{
    internal class CustomMath
    {
        public int SumOfOddNumber(int[] arr)
        {


            int sum = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 1)
                {
                    sum += item;
                }
            }
            return sum;
        }



        public void SearchOddOrTwin(int num)
        {

            if (num % 2 == 1)
            {
                Console.WriteLine("Tekdir");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("Cutdur");
            }
        }


        public int GetByMultiyplyArr(int[] arr)
        {
            int sum = 0;
            int result = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            result = sum * sum;

            return result;
        }




        public void FindTheProducOfNumber(int n)
        {
            int result = 1;

            for (int i = 1; n > i; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}














    
    


      




