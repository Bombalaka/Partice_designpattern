using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpattern
{
    internal class transport
    {
        //product interface 
        public interface ITransport
        {
            void Deliver();
        }
        public class Car : ITransport
        {
            public void Deliver()
            {
                Console.WriteLine("Delivering by car");
            }
        }
        public class Bus : ITransport
        {
            public void Deliver()
            {
                Console.WriteLine("Delivering by bus");
            }
        }
        public class Bike : ITransport
        {
            public void Deliver()
            {
                Console.WriteLine("Delivering by bike");
            }
        }
        // Factory 
        public class TransportFactory
        {
            public static ITransport CreateTransport(string type)
            {
                if (type.Equals("Car", StringComparison.OrdinalIgnoreCase))
                {
                    return new Car();
                }
                else if (type.Equals("Bus", StringComparison.OrdinalIgnoreCase))
                {
                    return new Bus();
                }
                else if (type.Equals("Bike", StringComparison.OrdinalIgnoreCase))
                {
                    return new Bike();
                }
                return null; // else {} retrun null like told user that it does not work. 
            }


        }

    }
}
