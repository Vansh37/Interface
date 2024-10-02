using System;

namespace MyApplication
{
    interface IVehicle
    {
        void Start();
        void Stop();
    }

    class Car: IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car Started.");
        }

        public void Stop()
        { 
            Console.WriteLine("Car Stooped.");
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Car myCar = new Car();
            myCar.Start();
            myCar.Stop();

        }
    }
}