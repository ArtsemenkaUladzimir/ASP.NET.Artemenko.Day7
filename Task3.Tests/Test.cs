using System;
using System.Collections.Generic;
using NUnit.Framework;
using Task3.Lib;

namespace Task3.Tests
{
	[TestFixture ()]
	public class Test
	{
		private CustomQueue<int> queueInt;

		[SetUp]
		public void Setup()
		{
			queueInt = new CustomQueue<int> ();
			queueInt.Enqueue (1);
			queueInt.Enqueue (3);
			queueInt.Enqueue (5);
		}

		[Test ()]
		public void TestLength ()
		{
			Assert.AreEqual (3, queueInt.Count);
		}

		[Test ()]
		public void TestLengthAfterDequeue ()
		{
			queueInt.Enqueue (7);
			queueInt.Enqueue (9);
			queueInt.Dequeue ();
			Assert.AreEqual (4, queueInt.Count);
		}

		[Test ()]
		public void TestPeek1 ()
		{
			queueInt.Enqueue (7);
			queueInt.Enqueue (9);
			queueInt.Dequeue ();
			Assert.AreEqual (3, queueInt.Peek ());
		}

		[Test ()]
		public void TestPeek2 ()
		{
			queueInt.Enqueue (9);
			queueInt.Dequeue ();
			queueInt.Dequeue ();
			queueInt.Dequeue ();
			Assert.AreEqual (9, queueInt.Peek ());
		}

		[Test ()]
		[ExpectedException ()]
		public void TestPeekException ()
		{
			queueInt.Dequeue ();
			queueInt.Dequeue ();
			queueInt.Dequeue ();
			Assert.AreEqual (9, queueInt.Peek ());
		}

		[Test ()]
		public void TestIterator ()
		{
			var list = new List<int> ();
			foreach (var i in queueInt) {
				list.Add (i);
			}
			Assert.AreEqual (3, list.Count);
		}
	}
}

