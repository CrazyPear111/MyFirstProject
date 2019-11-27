using System;


namespace ConsoleApp1
{
    class Min
    {
        public int MinVal(params int[] nums)
        {
            int m = nums[0];

            if (nums.Length == 0)
            {
                Console.WriteLine("Нет аргументов");
                return 0;
            }
             foreach(int val in nums)
            {
                if (val < m) m = val;
            }
            return m;
        }
    }
}
