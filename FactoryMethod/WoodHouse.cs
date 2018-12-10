using System;

namespace FactoryMethod
{
	public class WoodHouse : IHouse
	{
		public WoodHouse()
		{
		}

		public string GetHouseType() {
			return "Wood house";
		}
	}
}

