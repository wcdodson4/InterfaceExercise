using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
            Wheels = 4;
            Doors = 2;
            Seats = 2;
        }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public bool IsParked { get; set; }
        public bool IsInReverse { get; set; }

        public void Drive()
        {
            Console.WriteLine($"This truck drives with {Wheels} wheels, and it has {Doors} doors and {Seats} seats.");
        }
        public void Park()
        {
            IsParked = false;
            Console.WriteLine($"The truck is not parked.");
        }
        public void Reverse()
        {
            IsInReverse = true;
            Console.WriteLine($"The truck is in reverse.");
        }
        public void ShowLogo()
        {
            Console.WriteLine();
        }
    }
}
