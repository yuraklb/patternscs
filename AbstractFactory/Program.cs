using System;

namespace AbstractFactory
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			string param = "zerg";

			IFactory factory = null;


			switch(param) {
				case "protoss":
					factory = new ProtossFactory();
					break;
				case "terran":
					factory = new TerranFactory();
					break;
				case "zerg":
					factory = new ZergFactory();
					break;
				default:
					factory = null;
					break;
			}

			if(factory != null) {
				IUnit light = factory.CreateLightUnit();
				IUnit heavy = factory.CreateHeavyUnit();

				Console.WriteLine(light.BattleCry());
				Console.WriteLine(heavy.BattleCry());

			}
		}
	}
}
