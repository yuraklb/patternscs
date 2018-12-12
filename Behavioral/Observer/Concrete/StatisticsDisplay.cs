using System;

namespace Observer.Concrete
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {

        private float temperature;
        private float humidity;
        private ISubject weatherData;
        
        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
//            this.temperature = temperature;
//            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Statistics: ");
        }
        
    }
}