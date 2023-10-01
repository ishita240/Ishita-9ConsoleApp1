using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_9ConsoleApp1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Recursion : Find the factorial of a given number: ");
            Console.WriteLine(".......................................................");
            Console.WriteLine("Input any possitive number :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            long fact = FactorialCalcu(n1);
            Console.WriteLine("The Factorial of {0} is :{1}", n1, fact);
            Console.ReadLine();
        }
        private static long FactorialCalcu(int n1);
        
         if (n1 == 0)
            {
            return 1;
            }
            return n1 * FactorialCalcu(n1-1);
      }
    }

