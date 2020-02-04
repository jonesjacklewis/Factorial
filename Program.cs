using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
   

{
    class Program
    {
        static int  Fibonacci(int val) //function called Fibonacci ==> Recursive
        {
            if (val == 1) //if value is one
            {
                return 1; //return one
            }
            else
            {
                return val*Fibonacci(val - 1); //otherwise return val multiplied by the Fibonacci value of val-1
            }
        }
        static void Main(string[] args)
        {
            int n, Fibval; 
            String pass;
            Console.WriteLine("Enter a number to find the factorial of");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                Fibval = Fibonacci(n);
                Console.WriteLine(Fibval);
                Console.ReadLine();
                Console.WriteLine("Press Enter to Exit");
                pass = Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("Needs to be an integer");
                Console.ReadLine();
            }




        }
        


    }
}
