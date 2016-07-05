using System;

namespace AbstractFactory
{
	public interface IFactory
	{
		IUnit CreateHeavyUnit();
		IUnit CreateLightUnit();
	}
}

