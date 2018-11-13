using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Maximum is {numbers.Max()}");
            Boolean range = inRange(numbers[0], numbers[1], numbers[2]);
            Console.WriteLine($"Is it in range? {range}");
            Boolean prime = isPrimal(numbers[0]);
            Console.WriteLine($"Is it primal? {prime}");

            Console.ReadKey();


            
        }

        static Boolean inRange(int num1, int num2, int num3)
        {

            if ((num1>num2 && num1<num3) || (num1 < num2 && num1 > num3))
            {
                return true;
            }
            else return false;
        }

        static Boolean isPrimal(int num1)
        {

            if (num1%2!=0 && num1%3!=0 && num1 % 5 != 0 && num1 % 7 != 0)
            {
                return true;
            }
            else return false;
        }
    }
}
