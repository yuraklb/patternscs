using System;

namespace AbstractFactory
{
	public class ProtossHeavyUnit : IUnit
	{
		public ProtossHeavyUnit()
		{
		}

		public string BattleCry() {
			return "Protoss Heavy Unit";
		}
	}
}

