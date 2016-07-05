using System;

namespace AbstractFactory
{
	public class ZergLightUnit : IUnit
	{
		public ZergLightUnit()
		{
		}

		public string BattleCry() {
			return "Zerg Light Unit";
		}
	}
}

