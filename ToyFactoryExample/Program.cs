using System;

namespace ToyFactoryExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{

            // create a firetruck
            Console.WriteLine ("Creating a firetruck toy:");
            ToyCreator creator = new FiretruckCreator();
            creator.MakeToy();
			Console.WriteLine ();

			// create a superman
			Console.WriteLine ("Creating a superman toy:");
			creator = new SupermanCreator();
			creator.MakeToy();
			Console.WriteLine ();

			Console.Read();
		}
	}
}
