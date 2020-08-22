using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.DesignPattern
{
    /// Description:对象、观察者、显示接口
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver o);//注册观察者
        void RemoveObserver(IObserver o);//删除观察者
        void NotifyObervers();//通知观察者
    }

    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        void Display();
    }

    /// Description:WeatherData 注册、删除、通知观察者
    /// </summary>
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();//初始化obervers，用来存储注册的观察者
        }

        /// <summary>
        /// 注册观察者
        /// </summary>
        /// <param name="o"></param>
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="o"></param>
        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.Remove(o);
        }

        /// <summary>
        /// 通知观察者
        /// </summary>
        public void NotifyObervers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }

        /// <summary>
        /// 当从气象站得到更新观测值时，通知观察者
        /// </summary>
        public void MeasurementsChanged()
        {
            NotifyObervers();
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }

    /// Description:创建布告板
    /// </summary>
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Current coditions: " + temperature + "F degress and " + humidity + "% humidity");
        }
    }
}
