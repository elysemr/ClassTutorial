using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
    class MathLib
    {
        public int Mod(int x, int y)
        {
            return x - (x / y * y);
        }
        public int Inc(int x)
        {
            return ++x; //++ first to increment before returning value of a, can also do a+1
        }
        public int Add(int x, int y)
        {
            return x + y; 
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mult(int x, int y)
        { 
            return x * y; 
        }
        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
