using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Diagnostics;
namespace collatz_unparallelized
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            uint a = 1, b = 0, step = 0, c = 2, maxstep = 0, maxval = 1; bool bool1 = true, bool2;ConsoleKey consoleKey;
            while (bool1 == true)
            {
                a = c;
                do
                {
                    if (a % 2 == 0)
                    {
                        a /= 2;
                        step++;
                        Debug.WriteLine(a + " " + step);
                    }
                    else
                    {
                        a *= 3; a++;
                        step++;
                        Debug.WriteLine(a + " " + step);
                    }
                } while (a != 1);
                Console.WriteLine("Val {0} took {1} steps to reach 1", c, step);
                if (step > maxstep)
                {
                    maxstep = step;
                    maxval = c;
                    Console.WriteLine("Max value changed. New max number is {0} which took {1} steps to reach 1.", maxval, maxstep);
                }
                c++; step = 0; //reset for next run
            }
            Console.WriteLine("Number of values checked = {0}.\nMaximum number of steps occurred at {1}, with {2} steps.",c,maxval,maxstep);
            Console.ReadLine();
            consoleKey = Console.ReadKey().Key;
            if (consoleKey == ConsoleKey.Enter)
            {
                bool1 = false;
            }
        }
    }
}
