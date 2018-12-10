using System;

namespace Pool
{
	public class Unit
	{
		private int mX;
		private int mY;

		private bool mInUse;

		public Unit()
		{			
			mX = 0;
			mY = 0;
			mInUse = false;
		}

		public void Reset() {
			mX = 0;
			mY = 0;
		}

		public void SetPosition(int pX, int pY) {
			mX = pX;
			mY = pY;
		}

		public void SetInUse() {
			mInUse = true;
		}

		public bool IsInUse() {
			return mInUse;
		}
	}
}

