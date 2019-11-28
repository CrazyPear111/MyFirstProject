using System;

namespace ConsoleApp1
{
    class Rect
    {
        int width, height, bitches;

        public Rect(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return width * height;
        }
        public void Show()
        {
            Console.WriteLine(width + " " + height);
        }
        public Rect Enlarge(int factor)
        {
            return new Rect(width * factor, height * factor);
        }
    }
}
