namespace ConsoleApp1
{
	class FailSoftArray2D
	{
		private int[,] a;
		public int rows, cols;
		public int Length;
		public bool ErrFlag;

		public FailSoftArray2D(int rows, int cols)
		{
			this.rows = rows;
			this.cols = cols;
			a = new int[rows, cols];
			Length = rows * cols;
		}

		public int this[int index1, int index2]
		{
			get
			{
				if (Ok(index1, index2))
				{
					ErrFlag = false;
					return a[index1, index2];
				}
				else
				{
					ErrFlag = true;
					return 0;
				}
			}
			set
			{
				if (Ok(index1, index2))
				{
					ErrFlag = false;
					a[index1, index2] = value;
				}
				else ErrFlag = true;
			}
		}

		private bool Ok(int index1, int index2)
		{
			if (index1 >= 0 & index1 < rows & index2 >= 0 & index2 < cols) return true;
			else return false;
		}
	}
}
