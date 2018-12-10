using System;

namespace FactoryMethod
{
	public class PanelHouse : IHouse
	{
		public PanelHouse()
		{
		}

		public string GetHouseType() {
			return "Panel house";
		}
	}
}

