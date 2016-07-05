using System;

namespace AbstractFactory
{
	public class ProtossFactory : IFactory
	{
		public ProtossFactory()
		{
		}

		public IUnit CreateHeavyUnit() {
			return new ProtossHeavyUnit();
		}

		public IUnit CreateLightUnit() {
			return new ProtossLightUnit();
		}
	}
}

