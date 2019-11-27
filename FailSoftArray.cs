namespace ConsoleApp1
{
	class FailSoftArray
	{
		private int[] a;
		public int Length { get; private set; }
		public bool ErrFlag { get; private set; }

		public FailSoftArray(int size)
		{
			a = new int[size];
			Length = size;
		}
		
		public int this[int index]
		{
			get
			{
				if (Ok(index))
				{
					ErrFlag = false;
					return a[index];
				}
				else
				{
					ErrFlag = true;
					return 0;
				}
			}
			set
			{
				if (Ok(index))
				{
					a[index] = value;
					ErrFlag = false;
				}
				else ErrFlag = true;
			}
		}

		public int this[double index]
		{
			get
			{
				if (Ok((int)index))
				{
					ErrFlag = false;
					return a[(int)index];
				}
				else
				{
					ErrFlag = true;
					return 0;
				}
			}
			set
			{
				if (Ok((int) index))
				{
					ErrFlag = false;
					a[(int) index] = value;
				}
				else ErrFlag = true;
			}
		}

		private bool Ok(int index)
		{
			if (index >= 0 & index < Length) return true;
			else return false;
		}
	}
}
