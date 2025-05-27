using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{

    public class Car
    {
        private string make;
        private string model;

        public int Year { get; set; }

        internal void SetMakeAndModel(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        protected virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {make}, Model: {model}, Year: {Year}");
        }
    }


    public class ElectricCar : Car
    {
        private double batteryCapacity;

        public void SetBatteryCapacity(double capacity)
        {
            this.batteryCapacity = capacity;
        }

        protected override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Battery Capacity: {batteryCapacity} Км/ч");
        }

        public void ShowInfo()
        {
            DisplayInfo();
        }
    }
}

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new MyApp.Models.Car();


            car.SetMakeAndModel("Toyota", "Camry");
            car.Year = 2020; 

            var electricCar = new MyApp.Models.ElectricCar();
            electricCar.SetMakeAndModel("Tesla", "Model S");
            electricCar.Year = 2022;
            electricCar.SetBatteryCapacity(100.5); 


            Console.WriteLine("Информация о машине:");
            electricCar.ShowInfo();

            DisplayCarInfo(car);
            DisplayElectricCarInfo(electricCar);
        }

        static void DisplayCarInfo(MyApp.Models.Car car)
        {
            Console.WriteLine("\nАльтернативный способ отображения информации об автомобиле:");
            var method = typeof(MyApp.Models.Car).GetMethod("DisplayInfo",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(car, null);
        }

        static void DisplayElectricCarInfo(MyApp.Models.ElectricCar electricCar)
        {
            Console.WriteLine("\nАльтернативный способ отображения информации об электромобиле:");
            var method = typeof(MyApp.Models.ElectricCar).GetMethod("DisplayInfo",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            method.Invoke(electricCar, null);
        }
    }
}