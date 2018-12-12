using System.Collections.Generic;

namespace Observer.Concrete
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        
        
        public float temperature { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void registerObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}