namespace ConsoleApp1
{
	class SimpProp
	{
		private int prop;

		public SimpProp()
		{
			this.prop = 0;
		}

		public int MyProp
		{
			get { return prop; }
			set
			{
				if (value > 0) prop = value;
			}
		}
	}
}
