using System;

namespace FactoryMethod
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			IHouse house = null;

			IDeveloper developer = new WoodDeveloper();
			house = developer.Create();

			Console.WriteLine(house.GetHouseType());

			developer = new PanelDeveloper();
			house = developer.Create();

			Console.WriteLine(house.GetHouseType());
		}
	}
}
