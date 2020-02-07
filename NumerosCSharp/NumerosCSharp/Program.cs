using System;

namespace NumerosCSharp
{
    class Program
    {
		public static void Main()
		{
			imprime_nums(100);
		}

		static void imprime_nums(int n)
		{
			if (n > 0)
			{
				imprime_nums(n-1);
				Console.Write(n + " ");
			}
			return;
		}
	}
}
