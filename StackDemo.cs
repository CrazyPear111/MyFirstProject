//using System;

//class Stack
//{
//    private int count=0;
//    private string[] Arr;

//    public Stack(int size)
//    {
//        Arr = new string[size];
//    }

//    public void WriteData(string a)
//    {
//        if (count < Arr.Length)
//        {
//            Arr[count] = a;
//            count++;
//        }
//        else Console.WriteLine("Стек переполнен");
//    }
//    public string ReadData()
//    {
//        if (count > 0)
//        {
//            count--;
//            return Arr[count];
//        }
//        else
//        {
//            Console.WriteLine("Стек пуст");
//            return "0";
//        }
//    }
//}
//class StackDemo
//{
//    static void Main()
//    {
//        Stack mem_1 = new Stack(5);

//        while (true)
//        {
//            string key = Console.ReadLine();
//            if(key == "0")
//            {
//                Console.WriteLine(mem_1.ReadData());
//            }
//            else mem_1.WriteData(key);
//        }
//    }
//}



