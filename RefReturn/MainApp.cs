using System;

namespace RefReturn
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }

    class MainApp
    {
        static void Divide(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }


        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            int c = 0;
            int d = 0;

            Divide(a, b, ref c, ref d);

            Console.WriteLine($"c : {c}, d : {d}");

            //Product carrot = new Product();
            //ref int ref_local_price = ref carrot.GetPrice();
            //int normal_local_price = carrot.GetPrice();

            //carrot.PrintPrice();
            //Console.WriteLine($"Ref Local Price : {ref_local_price}");
            //Console.WriteLine($"Normal Local Price : {normal_local_price}");

            //ref_local_price = 200;

            //carrot.PrintPrice();
            //Console.WriteLine($"Ref Local Price : {ref_local_price}");
            //Console.WriteLine($"Normal Local Price : {normal_local_price}");
        }
    }
}
