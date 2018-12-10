using System;

namespace Builder
{
	public class CheapCarBuilder : ICarBuilder
	{
		private Car car = null;

		public CheapCarBuilder()
		{
			car = new Car();
		}

		public void BuildWheelPart() {
			car.SetWheelName("rosava");
		}
		public void BuildEnginePart() {
			car.SetEngineName("0.5cc");
		}
		public void BuildBodyPart() {
			car.SetBodyName("sedan");
		}
		public Car GetCar() {
			return car;
		}
	}
}