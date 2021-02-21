using System;
using System.Collections.Generic;

namespace Rajak
{
    class Mathematics
    {
        public static int Sum(List<int> numbers)
        {
            int result = 0;
            foreach(int number in numbers)
            {
                result += number;
            }
            return result;
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
