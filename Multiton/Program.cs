using System;

namespace Multiton
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Logger.getInstance("Hello");
			Logger.getInstance("World");
			Logger.getInstance("Hello");
		}
	}
}
