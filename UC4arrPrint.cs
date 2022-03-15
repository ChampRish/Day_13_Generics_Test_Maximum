using System;

namespace UC4arrPrint
{
    class Program
    {

        public class GenericMaximum<T> where T : IComparable
        {
            public T[] value;
            public GenericMaximum(T[] value)
            {
                this.value = value;
            }
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);
                return sorted_values[^1];
            }
            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }
            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is " + max);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 115, 848, 87, 432, 98 };
            GenericMaximum<int> obj = new GenericMaximum<int>(arr);
            obj.PrintMaxValue();
        }
    }
}
