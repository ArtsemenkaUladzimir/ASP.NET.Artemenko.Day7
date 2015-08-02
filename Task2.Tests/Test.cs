using System;
using System.Linq;
using NUnit.Framework;
using Task2.Lib;

namespace Task2.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase1 ()
		{
			Assert.AreEqual (4, Fibonacci.GetSequence (3).Sum ());
		}

		[Test ()]
		public void TestCase2 ()
		{
			Assert.AreEqual (7, Fibonacci.GetSequence (4).Sum ());
		}

		[Test ()]
		public void TestCase3 ()
		{
			Assert.AreEqual (20, Fibonacci.GetSequence (6).Sum ());
		}

		[Test ()]
		public void TestCase4 ()
		{
			Assert.AreEqual (33, Fibonacci.GetSequence (7).Sum ());
		}

		[Test ()]
		public void TestCase5 ()
		{
			Assert.AreEqual (54, Fibonacci.GetSequence (8).Sum ());
		}
	}
}

