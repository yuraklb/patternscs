using System;
using System.Collections.Generic;

namespace Multiton
{
	public class Logger
	{
		private static List<KeyValuePair<string, Logger>> _container = new List<KeyValuePair<string, Logger>>();

		public string mKeyName;

		public static Logger getInstance(string pKey) {

			foreach(var item in _container) {
				if(item.Key == pKey) {
					Console.WriteLine("Get instance");
					return item.Value;
				}
			}

			Console.WriteLine("Create new instance");

			var tmp = new KeyValuePair<string, Logger>(pKey, new Logger(pKey));

			_container.Add(tmp);

			return getInstance(pKey);
		}

		private Logger(string pKey)
		{
			mKeyName = pKey;
		}

		public string GetName() {
			return mKeyName;
		}
	}
}

