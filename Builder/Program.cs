using System;

namespace Builder
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Director director = new Director();

			ICarBuilder rcb = new RichCarBuilder();
			ICarBuilder ccb = new CheapCarBuilder();

			director.Construct(rcb);
			director.Construct(ccb);

			Console.WriteLine(rcb.GetCar().GetInfo());
			Console.WriteLine(ccb.GetCar().GetInfo());

		}
	}
}
