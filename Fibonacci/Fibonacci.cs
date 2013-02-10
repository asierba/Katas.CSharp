using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciKata
{
    public class Fibonacci
    {
        public static int Of(int index)
        {
            if(index == 0)
                return 0;
            if (index == 1 || index == 2)
                return 1;

            return Of(index - 1) + Of(index - 2);
        }
    }
}
