using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PartOne
    {
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

        private int DoubleTrouble(int x)
        {
            int y = 2;
            

            return y;
        }
    }
}
