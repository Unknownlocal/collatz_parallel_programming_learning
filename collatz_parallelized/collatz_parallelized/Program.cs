using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace collatz_parallelized
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 maxstep=0,maxval;
            Parallel.For(2, Int64.MaxValue, b =>
              {
                  Int64 a = b, step = 0;
                  while (a!=1)
                  {
                      if (a%2==0)
                      {
                          a /= 2;step++;
                      }
                      else
                      {
                          a *= 3;a++;step++;
                      }
                  }
                  if (step > maxstep)
                  {
                      maxstep = step;
                      maxval = b;
                      Console.WriteLine("Maximum number of steps so far achieved at val {0}, with {1} steps",maxval,maxstep);
                  }
              });
        }
    }
}
