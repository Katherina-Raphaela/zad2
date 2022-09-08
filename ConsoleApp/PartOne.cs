using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PartOne
    {
        private int DoubleTrouble(int x)
        {
            int y = 2;
            if (x < y)
            {
                return 1;
            }
            else
            {
                while (x >= y * 2)
                {
                    y = y * 2;
                }
            }
            return y;
        }

        public int Calcumulator(int number)
        {
            int holder = number;
            int counter = 0;
            while (holder > 0)
            {
                int deductor = DoubleTrouble(holder);
                holder = holder - deductor;
                counter++;
            }
            return counter;
        }
    }
}
