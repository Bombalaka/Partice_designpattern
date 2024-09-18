using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpattern
{
    //Factory mönster
    public class Factory
    {
        public interface Ivechice
        {
            void Start();
        }
        public class Car : Ivechice
        {
            public void Start()
            {
                Console.WriteLine("Car is starting");
            }
        }
        public class Bike : Ivechice
        {
            public void Start()
            {
                Console.WriteLine("Bike is starting");
            }
        }

        // Singleton instance of Factory
        private static Factory instance;
       
        // Private constructor to prevent instantiation
        private Factory() { }

        // Method to get and check the Singleton instance of the Factory,
        // if it has already so it will return itself,the otherwise it will create a new once. 
        public static Factory GetInstance()
        {
            if (instance == null)
            {
                instance = new Factory();
            }
            return instance;
        }
        // Factory method to create vehicles
        public Ivechice CreateVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "Car":
                    return new Car(); // ger tillbaka bilen utan att starta direk
                case "Bike":
                    return new Bike(); // ger tillbaka cykeln utan att starta direk
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
