using System;

namespace Builder
{
	public class RichCarBuilder : ICarBuilder
	{
		private Car car = null;

		public RichCarBuilder()
		{
			car = new Car();
		}

		public void BuildWheelPart() {
			car.SetWheelName("kumho");
		}
		public void BuildEnginePart() {
			car.SetEngineName("100500cc");
		}
		public void BuildBodyPart() {
			car.SetBodyName("crossover");
		}
		public Car GetCar() {
			return car;
		}

	}
}

