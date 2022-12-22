using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Perfect Numbers Between {0} and {1}", num1, num2);

            // If 2^p - 1 is a prime, then (2^p - 1).2^(p-1) is perfect
            //  and if 2^p - 1 is a prime, so p is a prime
            //  all prime numbers are odd, so we will begin with constant i = 3
            int i = 3;
            int perfect = 0;
            // the output of the missing prime '2' = 6
            // so we will print '6' if the input <= 6
            if (num1 <= 6)
                Console.WriteLine(6);
            while (perfect <= num2)                                      
            {
                int mers = (int)(Math.Pow(2, i) - 1);
                if (prime1(mers))
                {
                    perfect = mers * (int)Math.Pow(2, i-1);
                    if(perfect >= num1 && perfect <= num2)
                        Console.WriteLine(perfect);
                }
                i += 2;
            }
            Console.ReadKey();
        }
        static bool prime1(int x)                   // method to determine if the input "x" is prime
        {
            bool Is_Prime = true;
            if (x % 2 != 0)                                         // all prime numbers are odd
                for (int i = 3; i <= Math.Sqrt(x); i += 2)         // and x is prime when x hasn't a prime divisor <= √x
                {
                    if (x % i == 0)
                    {
                        Is_Prime = false;
                        break;
                    }
                }
            else Is_Prime = false;
            return Is_Prime;
        }
    }
}
