using System;

namespace calculatorinterface
{
    public interface Iinterface1
    {
        void add(int a, int b);
        void sub(int a, int b);
        void mul(int a, int b);
        void divi(double a, double b);
        void display();
    }
    class inter : Iinterface1
    {
        int x, y, z;
        double d;
        public void add(int a, int b)
        {
            int m, n;
            m = a;
            n = b;
            x = m + n;
        }
        public void sub(int a, int b)
        {
            int m, n;
            m = a;
            n = b;
            y = a - b;
        }
        public void mul(int a, int b)
        {
            int m, n;
            m = a;
            n = b;
            z = a * b;
        }
        public void divi(double a, double b)
        {
            double m, n;
            m = a;
            n = b;
            d = a / b;
        }
        public void display()
        {
            Console.WriteLine("Addition value is:" + x);
            Console.WriteLine("Subtraction value is:" + y);
            Console.WriteLine("Multiplication value is:" + z);
            Console.WriteLine("Divition value is:" + d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            inter obj = new inter();
            int g, h;


            Console.WriteLine("Enter the first Number to perform calculator operations:");
            g = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the second Number to perform calculator operations:");
            h = Convert.ToInt16(Console.ReadLine());
            obj.add(g, h);
            obj.sub(g, h);
            obj.mul(g, h);
            obj.divi(g, h);
            obj.display();
            Console.ReadKey();
        }
    }
}
