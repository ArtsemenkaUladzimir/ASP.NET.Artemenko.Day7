using System;
using System.Collections.Generic;

namespace Task4.Lib
{
	public static class ArrayExtension
	{
		#region public methods

		public static int BinarySearch<T> (T[] array, T value)
		{
			if (ReferenceEquals (array, null))
				throw new ArgumentNullException ("array");

			return BinarySearch (array, value, 0, array.Length, Comparer<T>.Default.Compare);
		}

		public static int BinarySearch<T> (T[] array, T value, Comparison<T> compare)
		{
			if (ReferenceEquals (array, null))
				throw new ArgumentNullException ("array");
			
			return BinarySearch (array, value, 0, array.Length, compare);
		}
			
		public static int BinarySearch<T> (T[] array, T value, IComparer<T> comparer)
		{
			if (ReferenceEquals (array, null))
				throw new ArgumentNullException ("array");
			if (ReferenceEquals (comparer, null))
				throw new ArgumentNullException ("comparer");

			return BinarySearch (array, value, 0, array.Length, comparer.Compare);
		}

		#endregion

		#region private methods

		private static int BinarySearch<T> (T[] array, T value, int left, int right, Comparison<T> compare)
		{
			int mid = left + (right - left) / 2;
			if (left >= right || array.Length == 0)
				return -1;

			if (compare (array [mid], value) == 0)
				return mid;

			if (compare (array [mid], value) > 0)
				return BinarySearch (array, value, left, mid, compare);
			return BinarySearch (array, value, mid + 1, right, compare);
		}

		#endregion
	}
}

