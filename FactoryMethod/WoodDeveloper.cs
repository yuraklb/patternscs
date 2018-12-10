using System;

namespace FactoryMethod
{
	public class WoodDeveloper : IDeveloper
	{
		public WoodDeveloper()
		{
		}

		public IHouse Create() {
			return new WoodHouse();
		}
	}
}

