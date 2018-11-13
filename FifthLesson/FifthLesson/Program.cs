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
            Console.WriteLine($"Didziausias yra {numbers.Max()}");
            Console.ReadKey();
            
        }
    }
}
