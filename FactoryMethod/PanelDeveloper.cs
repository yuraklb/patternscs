using System;

namespace FactoryMethod
{
	public class PanelDeveloper : IDeveloper
	{
		public PanelDeveloper()
		{
		}

		public IHouse Create() {
			return new PanelHouse();
		}
	}
}

