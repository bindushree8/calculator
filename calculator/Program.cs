
using System;

namespace calculatorinterface
{


    public interface Iinterface1
    {
        void display();
    }

    class displays : Iinterface1
    {
        public void display()
        {
            Console.WriteLine("Thank you ");

        }
    }



    class addition
    {

        public void add(int a, int b)
        {
            int m, n, x;
            m = a;
            n = b;
            x = m + n;
            Console.WriteLine("Addition value is:" + x);
        }
    }


    class subtraction
    {

        public void sub(int a, int b)
        {
            int m, n, x;
            m = a;
            n = b;
            x = m - n;
            Console.WriteLine("Subtraction value is:" + x);
        }
    }

    class multiplication
    {

        public void mul(int a, int b)
        {
            int m, n, x;
            m = a;
            n = b;
            x = a * b;
            Console.WriteLine("Multiplication value is:" + x);
        }
    }

    class division
    {

        public void divi(double a, double b)
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
                addition obj1 = new addition();

                subtraction obj2 = new subtraction();

                multiplication obj3 = new multiplication();

                division obj4 = new division();

                displays obj5 = new displays();


                Console.WriteLine("Enter the first Number to perform calculator operations:");
                g = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the second Number to perform calculator operations:");
                h = Convert.ToInt16(Console.ReadLine());

               
                obj1.add(g,h);
    
                obj2.sub(g, h);
                
                obj3.mul(g, h);

                obj4.divi(g, h);

                obj5.display();

                Console.ReadKey();
            }
        }
    }

}





