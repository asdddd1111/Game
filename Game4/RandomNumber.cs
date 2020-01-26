using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public static class RandomNumber
    {
        public static Random random = new Random();
        public static int Get(int minValue,int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
