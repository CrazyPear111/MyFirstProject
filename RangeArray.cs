using System;

namespace ConsoleApp1
{
	class RangeArray
	{
		private int[] _a;
		private int _lowerBound;
		private int _upperBound;

		public int Length { get; private set; }
		public bool Error { get; private set; }

		public RangeArray(int lowerBound, int upperBound)
		{
			if (upperBound <= lowerBound)
			{
				Console.WriteLine("Неверные индексы");
				upperBound = 1;
				lowerBound = 0;
			}
			Length = upperBound - lowerBound;
			_a = new int[Length];
			_lowerBound = lowerBound;
			_upperBound = upperBound;
		}
		public int this[int index]
		{
			get
			{
				if (Ok(index))
				{
					Error = false;
					return _a[index-_lowerBound];
				}
				else
				{
					Error = true;
					return 0;
				}
			}
			set
			{
				if (Ok(index))
				{
					Error = false;
					_a[index-_lowerBound] = value;
				}
				else Error = true;
			}
		}
		bool Ok(int index)
		{
			if (index >= _lowerBound & index < _upperBound) return true;
			else return false;
		}
	}
}
