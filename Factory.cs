using System;

namespace ConsoleApp1
{
	class MyClass
	{
		int a, b;

		static public MyClass Factory(int i, int j)
		{
			MyClass temp = new MyClass();
			temp.a = i;
			temp.b = j;
			return temp;
		}
		public void Show()
		{
			Console.WriteLine("a and b: " + a + " " + b);
		}
	}
}
