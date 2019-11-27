using System;

//namespace ConsoleApp1;
class Rect
{
    public int Width, Heigth;
    public Rect(int w, int h)
    {
        Width = w;
        Heigth = h;
    }
    public int Area()
    {
        return Width * Heigth;
    }
}

class UseRect
{
    static void Main()
    {
        Rect r1 = new Rect(2, 3);
        Rect r2 = new Rect(4, 5);
        Console.WriteLine("Площадь прямоугольника 1 = " + r1.Area());
        Console.WriteLine("Площадь прямоугольника 2 = " + r2.Area());
    }
}

