using System;
using Observer.Concrete;

namespace Observer
{
	internal static class MainClass
	{
		public static void Main(string[] args)
		{
		WeatherData weatherData = new WeatherData();
			CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
			
			weatherData.setMeasurements(80,65,30.4f);
			weatherData.setMeasurements(82,70,29.4f);
			weatherData.setMeasurements(78,90,29.4f);
		}
	}
}
