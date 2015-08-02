using System;
using System.Collections.Generic;

namespace Task3.Lib
{
	public class CustomQueue<T>
	{
		#region private members
		private T[] queue;
		private const int _defaultCapasity = 10;
		private int _head;
		private int _tail;
		#endregion

		#region properties
		public int Count { get { return _tail - _head + 1; } }
		#endregion

		#region ctors
		public CustomQueue ()
		{
			_head = 0;
			_tail = -1;
			queue = new T[_defaultCapasity];
		}
		#endregion

		#region public methods
		public void Enqueue (T item)
		{
			ResizeQueue ();

			_tail++;
			queue [_tail] = item;
		}

		public T Dequeue ()
		{
			if (Count == 0)
				throw new InvalidOperationException ("Queue is empty");

			var res = queue [_head];
			queue [_head] = default(T);
			_head++;

			return res;
		}

		public T Peek ()
		{
			if (Count == 0)
				throw new InvalidOperationException ("Queue is empty");

			return queue [_head];
		}
			
		public CustomQueueIterator GetEnumerator ()
		{
			return new CustomQueueIterator (this);
		}
		#endregion

		#region Iterator
		public class CustomQueueIterator
		{
			private readonly CustomQueue<T> queue;
			private int curIndex = -1;

			public CustomQueueIterator (CustomQueue<T> queue)
			{
				this.queue = queue;
			}

			public bool MoveNext ()
			{
				return ++curIndex < queue.Count;
			}

			public void Reset ()
			{
				curIndex = -1;
			}
				
			public T Current {
				get {
					if (curIndex == -1 || curIndex == queue.Count)
						throw new InvalidOperationException ();
					
					return queue.queue [curIndex];
				}
			}
		}
		#endregion

		#region private methods
		private void ResizeQueue ()
		{
			if (_tail >= queue.Length - 1) {
				var tmp = new T[Count * 2];
				queue.CopyTo (tmp, _head);
				queue = tmp;
				_head = 0;
				_tail = Count - 1;
			}
		}
		#endregion
	}
}

