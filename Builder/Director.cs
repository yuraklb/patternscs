using System;

namespace Builder
{
	public class Director
	{
		public void Construct(ICarBuilder pBuilder) {
			pBuilder.BuildWheelPart();
			pBuilder.BuildEnginePart();
			pBuilder.BuildBodyPart();
		}
	}
}

