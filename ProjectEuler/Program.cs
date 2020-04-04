using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SieveOfEratosthenes());
        }

        static Int64 SieveOfEratosthenes()
        {
            var len = 2000000;
            var a = new bool[len];
            Int64 sum = 0;

            for (int i = 0; i < len; i++)
            {
                a[i] = true;
            }

            for (int i = 2; i*i < len; i++)
            {
                if (a[i])
                {
                    for (int j = i*i; j < len; j += i)
                    {
                        a[j] = false;
                    }
                }
            }

            for (int i = 2; i < len; i++)
            {
                if(a[i])
                {
                    sum += i;
                }
            }

            return sum;
        }

        // Sieve of Eratosthenes
        /* https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
         algorithm Sieve of Eratosthenes is

            input: an integer n > 1.
            output: all prime numbers from 2 through n.

            let A be an array of Boolean values, indexed by integers 2 to n,
            initially all set to true.
    
            for i = 2, 3, 4, ..., not exceeding √n do
                if A[i] is true
                    for j = i2, i2+i, i2+2i, i2+3i, ..., not exceeding n do
                        A[j] := false

            return all i such that A[i] is true.
         */
    }
}
