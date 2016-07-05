using System;

namespace AbstractFactory
{
	public class TerranHeavyUnit : IUnit
	{
		public TerranHeavyUnit()
		{
		}

		public string BattleCry() {
			return "Terran Heavy Unit";
		}
	}
}

