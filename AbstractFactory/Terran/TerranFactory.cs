using System;

namespace AbstractFactory
{
	public class TerranFactory : IFactory
	{
		public TerranFactory()
		{
		}

		public IUnit CreateHeavyUnit() {
			return new TerranHeavyUnit();
		}

		public IUnit CreateLightUnit() {
			return new TerranLightUnit();
		}
	}
}

