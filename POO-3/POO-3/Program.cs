using System;

namespace POO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fatorial(2));
            
            
        }
        public static int fatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * fatorial(n - 1);
        }
    }
}
