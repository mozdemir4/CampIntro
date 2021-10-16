using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Console.WriteLine(Add2(25, 15));
            //Console.WriteLine(Add3(5));

            //int x = 10, y=20;


            //Console.WriteLine(Islem(ref x, y));
            //Console.WriteLine(x);

            //int sayi1;
            //int sayi2 = 20;

            //Console.WriteLine(Islem2(out sayi1, sayi2));

            Console.WriteLine(Multiply(5, 4));
            Console.WriteLine(Multiply(1, 2, 3, 4));

            Console.WriteLine(Multiply(5, 10, 20, 50, 100, 100, 200));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added for changing");
        }
        static int Add2(int a, int b)
        {
            var result = a + b;
            return result;
        }

        //default parametreli
        static int Add3(int number1,int number2= 4, int number3 = 5)
        {
            var result = number1 * number2 * number3;
            return result;
        }

        //ref keyword
        static int Islem(ref int x, int y)
        {
            x = 30;
            return x + y;
        }

        //out keyword --
        static int Islem2(out int sayi1,int sayi2)
        {
            sayi1 = 100;
            return sayi1 + sayi2;
        }

        //method overloading

        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Multiply(int a,int b, int c, int d)
        {
            return a * b * c * d;
        }

        //params keyword

        static int Multiply(params int[] numbers)
        {
            return numbers.Sum();
        }





    }
}
