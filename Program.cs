using System;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main()
        {
			Triangle t1 = new Triangle();
			Triangle t2 = new Triangle();

			t1.Height = 4;
			t1.Width = 4;
			t1.Style = "Равнобедренный";

			t2.Height = 8;
			t2.Width = 12;
			t2.Style = "Прямоугольный";

			Console.WriteLine("Сведения об объекте t1: ");

			t1.Show();
			t1.ShowDim();
			Console.WriteLine("Площадь равна: " + t1.Area());

			Console.WriteLine();
			Console.WriteLine("Сведения об объекте t2: ");

			t2.Show();
			t2.ShowDim();
			Console.WriteLine("Площадь равна " + t2.Area());
		}
    }
}