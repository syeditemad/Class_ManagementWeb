using System;

namespace Anynomouse_function
{
    public delegate void Calculation( int b);
    class Program
    {
        public static void Addition(Calculation del ,int b)
        {
            Console.WriteLine("Addition of Two number {0}",b);
        }

        static void Main(string[] args)
        {
            Calculation obj = delegate (int a)
            {
                a += 10;
                Console.WriteLine(a);

            };
            obj.Invoke(10);
        }
    }
}
