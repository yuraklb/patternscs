using System;

namespace AbstractFactory
{
	public class ProtossLightUnit : IUnit
	{
		public ProtossLightUnit()
		{
		}

		public string BattleCry() {
			return "Protoss Light Unit";
		}
	}
}

