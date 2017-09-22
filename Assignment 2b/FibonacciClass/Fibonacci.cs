using System;

namespace FibonacciClass
{
    public class Fibonacci
    {
        public int Check(int num)
        {
            int n1 = 0, n2 = 1, n3 = 0;
            for (int i = 0; i <= num; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
            return n2;
        }
    }
}