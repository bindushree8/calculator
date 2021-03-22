

using System;

namespace CalculatorInterface
{


    public interface IInterface
    {
        void Calculation(int a,int b);
        


    }

   

    class Addition:IInterface
    {

        public void Calculation(int a, int b)
        {
            int m, n, x;
            m = a;
            n = b;
            x = m + n;
            Console.WriteLine("Addition value is:" + x);
        }
    }


    class Subtraction:IInterface
    {

        public void Calculation(int a, int b)
        {
            int m, n, x;
            m = a;
            n = b;
            x = m - n;
            Console.WriteLine("Subtraction value is:" + x);
        }
    }

    class Multiplication:IInterface
    {

        public void Calculation(int a, int b)
        {
            int m, n, x;
            m = a;
            n = b;
            x = a * b;
            Console.WriteLine("Multiplication value is:" + x);
        }
    }

    class Division : IInterface
    {

        public void Calculation(int a, int b)
        {
            double m, n, d;
            m = a;
            n = b;
            d = a / b;
            Console.WriteLine("Divition value is:" + d);
        }





        class Program
        {
            static void Main(string[] args)
            {
                int g, h;
                Addition obj1 = new Addition();

                Subtraction obj2 = new Subtraction();

                Multiplication obj3 = new Multiplication();

                Division obj4 = new Division();



                Console.WriteLine("Enter the first Number to perform calculator operations:");
                g = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the second Number to perform calculator operations:");
                h = Convert.ToInt16(Console.ReadLine());


                obj1.Calculation(g, h);

                obj2.Calculation(g, h);

                obj3.Calculation(g, h);

                obj4.Calculation(g, h);



                Console.ReadKey();
            }
        }





    }

 }


