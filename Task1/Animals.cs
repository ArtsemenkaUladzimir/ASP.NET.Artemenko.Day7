using System;

namespace Task1.Entities
{
	public class Dog : ICommonAnimal
	{
		#region ctor
		public Dog (Sender sender)
		{
			sender.Mail += Voice;
		}
		#endregion

		public void Unregister (Sender sender)
		{
			sender.Mail -= Voice;
		}

		#region ICommonAnimal implementation
		public void Voice (object sender, string message)
		{
			if (message == null)
				throw new ArgumentNullException ();
			
			Console.WriteLine (String.Format ("I'm dog. {0}", message));
		}
		#endregion
	}

	public class Cat : ICommonAnimal
	{
		#region ctor
		public Cat (Sender sender)
		{
			sender.Mail += Voice;
		}
		#endregion

		public void Unregister (Sender sender)
		{
			sender.Mail -= Voice;
		}

		#region ICommonAnimal implementation
		public void Voice (object sender, string message)
		{
			if (message == null)
				throw new ArgumentNullException ();
			
			Console.WriteLine (String.Format ("I'm cat. {0}", message));
		}
		#endregion
	}
}

