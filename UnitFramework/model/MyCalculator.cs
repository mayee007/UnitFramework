using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitFramework.model
{
    class MyCalculator
    {
        int x;
        int y; 
        
        public MyCalculator(int a, int b)
        {
            x = a;
            y = b; 
        }

        public int add()
        {
            return x + y; 
        }

        public int subtract()
        {
            return x - y;
        }

        public int multiply()
        {
            return x * y;
        }

        public int divide()
        {
            return x / y;
        }
    }
}
