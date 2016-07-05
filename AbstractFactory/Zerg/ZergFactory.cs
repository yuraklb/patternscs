using System;

namespace AbstractFactory
{
	public class ZergFactory : IFactory
	{
		public ZergFactory()
		{
		}

		public IUnit CreateHeavyUnit() {
			return new ZergHeavyUnit();
		}

		public IUnit CreateLightUnit() {
			return new ZergLightUnit();
		}
	}
}

