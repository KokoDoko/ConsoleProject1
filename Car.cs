using System;

namespace ConsoleProject1
{
	class Car
	{
		public Car()
		{
			Console.WriteLine("Starting the car...");
		}

		public void Drive(){
			Console.WriteLine("Vroom!");
		}
		
		public void Stop(){
			Console.WriteLine("Stopping the car...");
		}
	}
}
