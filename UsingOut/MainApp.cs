using System;

namespace UsingOut
{
    class MainApp
    {
        static int[] Divide(int a, int b)
        {
            int[] abc = new int[2];
            abc[0] = a / b;
            abc[1] = a % b;

            return abc;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            int[] cde;
            //int c;
            //int d;

            cde = Divide(a, b);

            Console.WriteLine("a:{0}, b:{1}", a, b);
            Console.WriteLine($"a:{a}, b:{b}, a/b:{cde[0]}, a%b:{cde[1]}");
        }
    }
}
