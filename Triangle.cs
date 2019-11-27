using System;

namespace ConsoleApp1
{
	class Triangle : TwoDShape
	{
		public string Style;

		public double Area()
		{
			return Width * Height / 2;
		}

		public void Show()
		{
			Console.WriteLine("Треугольник" + Style);
		}
	}
}
