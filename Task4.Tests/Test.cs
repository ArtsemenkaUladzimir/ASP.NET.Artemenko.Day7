using System;
using NUnit.Framework;
using Task4.Lib;

namespace Task4.Tests
{
	[TestFixture ()]
	public class Test
	{
		int[] arr;

		[SetUp]
		public void Setup ()
		{
			arr = new int[] { 2, 4, 7, 8, 9, 12, 34, 53, 67 };
		}

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

		[Test]
		public void InterpolationSearch0 ()
		{
			Assert.AreEqual (0, ArrayExtension.InterpolationSearch (arr, 2));
		}

		[Test]
		public void InterpolationSearch1 ()
		{
			Assert.AreEqual (3, ArrayExtension.InterpolationSearch (arr, 8));
		}

		[Test]
		public void InterpolationSearch2 ()
		{
			Assert.AreEqual (5, ArrayExtension.InterpolationSearch (arr, 12));
		}

		[Test]
		public void InterpolationSearch3 ()
		{
			Assert.AreEqual (8, ArrayExtension.InterpolationSearch (arr, 67));
		}

		[Test]
		public void InterpolationSearch4 ()
		{
			Assert.AreEqual (-1, ArrayExtension.InterpolationSearch (arr, 321));
		}

		[Test]
		public void InterpolationSearch5 ()
		{
			Assert.AreEqual (-1, ArrayExtension.InterpolationSearch (arr, -42));
		}
	}
}

