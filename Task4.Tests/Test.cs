using System;
using NUnit.Framework;
using Task4.Lib;

namespace Task4.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
			Assert.AreEqual (0, ArrayExtension.BinarySearch (new int[] { 2, 3, 4 }, 2));
		}

		[Test ()]
		public void TestCase1 ()
		{
			Assert.AreEqual (2, ArrayExtension.BinarySearch (new int[] { 4, 3, 2 }, 2, 
				compare: (a, b) => a == b ? 0 : (a > b ? -1 : 1)));
		}
	}
}

