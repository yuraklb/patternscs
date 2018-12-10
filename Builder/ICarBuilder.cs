using System;

namespace Builder
{
	public interface ICarBuilder
	{
		void BuildWheelPart();
		void BuildEnginePart();
		void BuildBodyPart();
		Car GetCar();
	}
}

