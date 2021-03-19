using System;
public class Program
{
	public int add(int x, int y)
	{
		int result = x + y;
		return result;
	}

		public int sub(int x, int y)
		{
			int result = x - y;
			return result;
		}

		public int mul(int x, int y)
		{
			int result = x * y;
			return result;
		}

	public int div(int x, int y)
	{
		int result = x / y;
		return result;
	}


	public static void Main(string[] args)
	{
		int x, y, s;

		Console.Write("Enter first number:");
        x = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter second number:");
		y = Convert.ToInt32(Console.ReadLine());

		Program obj1 = new Program();
		s = obj1.add(x, y);
		Console.WriteLine("Sum is:" + s);



		Program obj2 = new Program();
		s = obj2.sub(x, y);
		Console.WriteLine("Subtraction  is:" + s);


		Program obj3 = new Program();
		s = obj3.mul(x, y);
		Console.WriteLine("multiplcation is:" + s);


		Program obj4 = new Program();
		s = obj4.div(x, y);
		Console.WriteLine("division is:" + s);

		
	}
}