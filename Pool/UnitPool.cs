using System;
using System.Collections.Generic;

namespace Pool
{
	public class UnitPool
	{
		private List<Unit> lunits;

		public UnitPool()
		{
			lunits = new List<Unit>();
			for(int i = 0; i < 100; i++) {
				lunits.Add(new Unit());
			}
		}

		public Unit GetUnit() {
			foreach(var item in lunits) {
				if(! item.IsInUse()) {
					item.SetInUse();
					return item;
				}
			}

			Unit tmp = new Unit();
			lunits.Add(tmp);
			tmp.SetInUse();
			return tmp;
		}

		public void ResetUnit(Unit pUnit) {
			pUnit.Reset();
		}
	}
}

