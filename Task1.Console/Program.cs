using System;
using Task1.Entities;

namespace Task1.Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var sender = new Sender ();
			var dog = new Dog (sender);
			var cat = new Cat (sender);

			sender.StartTimer (1000, "Before unregister");

			dog.Unregister (sender);
			sender.StartTimer (2000, "After unregister");
		}
	}
}
