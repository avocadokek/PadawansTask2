using System;

namespace PadawansTask2
{

    public static class ArithmeticSequence
    {

        public static int Calculate(int number, int add, int count)
        {
            int Sum = 0;
            for (int i = 0; i < count; i++)
            {
                Sum += (number + i * add);
            }

            return Sum;
            throw new NotImplementedException();
        }

        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            var result = Calculate(a, b, c);
            Console.WriteLine($"Result: {result}");
        }
    }
}
