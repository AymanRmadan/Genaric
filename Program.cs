using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegete.Program;

namespace Delegete
{
    internal class Program
    {
       // public delegate bool Filter(int n);
        public delegate bool Filter<T>(T n);
        static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Numbers Less Than 6");
            //PrintNumbersLessThanSix(list);
            //PrintNumbersLessThanSix(list,5);
            //PrintNumbersLessThanSix(list);
            //PrintNumbersLessThanSix(list,n=>n%2!=0);
            PrintNumbersLessThanSix(list, n => n % 2 == 0);

            Console.ReadKey();
        }

        /* static void PrintNumbersLessThanSix(IEnumerable<int> numbers)
         {
             foreach(var n in numbers)
             {
                 if(n < 6)
                 { 
                     Console.Write(n);
                 }
                 Console.Write(" ");
             }
         }*/

        /*static void PrintNumbersLessThanSix(IEnumerable<int> numbers , int pivot)
        {
            foreach (var n in numbers)
            {
                if (n < pivot)
                {
                    Console.Write(n);
                }
                Console.Write(" ");
            }
        }*/

        /* static void PrintNumbersLessThanSix(IEnumerable<int> numbers)
         {
             foreach (var n in numbers)
             {
                 if (n % 2 == 0)
                 {
                     Console.Write(n);
                 }
                 Console.Write(" ");
             }
         }*/

        /* static void PrintNumbersLessThanSix(IEnumerable<int> numbers, Filter filter)
         {
             foreach (var n in numbers)
             {
                 if (filter(n))
                 {
                     Console.Write(n);
                 }
                 Console.Write(" ");
             }
         }*/


        /*static void PrintNumbersLessThanSix<T>(IEnumerable<T> numbers, Filter<T> filter)
        {
            foreach (var n in numbers)
            {
                if (filter(n))
                {
                    Console.Write(n);
                }
                Console.Write(" ");
            }
        }*/

        static void PrintNumbersLessThanSix<T>(IEnumerable<T> numbers, Predicate<T> filter)
        {
            foreach (var n in numbers)
            {
                if (filter(n))
                {
                    Console.Write(n);
                }
                Console.Write(" ");
            }
        }
    }


}
