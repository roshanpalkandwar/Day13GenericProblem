using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13AssigimentGeneric
{
    public class Maximum_Number
    {
        public int[] value;

        public Maximum_Number(int[] value)
        {
            this.value = value;
        }

        public int[] Sort(int[] values)
        {
            Array.Sort(values);
            return values;
        }

        public int MaxValues(params int[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        public int MaxMethod()
        {
            var max = MaxValues(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValues(this.value);
            Console.WriteLine("Maximum value is " + max);
        }

    }
}
