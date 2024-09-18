using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using static designpattern.transport; // importera klassen transport

namespace designpattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // get instance (sigleton)
            Factory factory = Factory.GetInstance(); 
            // create a fondor (Factory)
            var Mycar = factory.CreateVehicle(Factory.VehicleType.Car);
            Mycar.Start();
        }
    }
}
