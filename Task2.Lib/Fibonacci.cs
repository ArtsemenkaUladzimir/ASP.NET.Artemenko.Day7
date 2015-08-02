using System;
using System.Collections.Generic;

namespace Task2.Lib
{
	public static class Fibonacci
	{
		public static IEnumerable<int> GetSequence (int n)
		{
			if (n < 1)
				throw new ArgumentException ();
			
			int a = 0, b = 1, temp;
			yield return b;
			for (int i = 1; i < n; i++) {
				temp = a;
				a = b;
				b = temp + b;
				yield return b;
			}
		}
	}
}

