using System;

namespace Pool
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			UnitPool up = new UnitPool();

			Unit u = up.GetUnit();

			u.SetPosition(1, 1);

			up.ResetUnit(u);
		}
	}
}
