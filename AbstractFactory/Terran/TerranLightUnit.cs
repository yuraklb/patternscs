using System;

namespace AbstractFactory
{
	public class TerranLightUnit : IUnit
	{
		public TerranLightUnit()
		{
		}

		public string BattleCry() {
			return "Terran Light Unit";
		}
	}
}

