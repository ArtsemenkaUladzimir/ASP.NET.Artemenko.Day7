using System;
using System.Threading;

namespace Task1.Entities
{
	public sealed class Sender
	{
		public event EventHandler<string> Mail;

		#region ctor
		public Sender()
		{
			Mail += delegate(object sender, string e) {};
		}
		#endregion

		public void StartTimer (int msecond, string mail)
		{
			Thread.Sleep (msecond);

			if (Mail == null)
				throw new NullReferenceException ();

			Mail (this, mail);
		}
	}
}

