using System;

namespace Builder
{
	public class Car
	{
		private string mWheelName;
		private string mEngineName;
		private string mBodyName;

		public void SetWheelName(string pName) {
			mWheelName = pName;
		}
		public void SetEngineName(string pName) {
			mEngineName = pName;
		}
		public void SetBodyName(string pName) {
			mBodyName = pName;
		}

		public string GetInfo() {
			return "Wheel: " + mWheelName + " Engine: " + mEngineName + " Body: " + mBodyName;
		}
	}
}

