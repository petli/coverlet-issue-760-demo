using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class Implementation
    {
        public static async Task<int> If()
        {
            var numbers = (IEnumerable<int>)new[] { 1, 2, 3, 4, 5 };
            var result = 0;

            if (numbers.Select(i => i * 2).Count() == 5)
            {
                result = 1;
            }

            await Task.Delay(100);
            return result;
        }

        public static async Task<int> Foreach()
        {
            var numbers = (IEnumerable<int>)new[] { 1, 2, 3, 4, 5 };
            var sum = 0;

            foreach (var i in numbers.Select(n => n * 2))
            {
                sum += i;
            }

            await Task.Delay(100);
            return sum;
        }
    }
}
