using System;

namespace AbstractFactory
{
	public class ZergHeavyUnit : IUnit
	{
		public ZergHeavyUnit()
		{
		}

		public string BattleCry() {
			return "Zerg Heavy Unit";
		}
	}
}

