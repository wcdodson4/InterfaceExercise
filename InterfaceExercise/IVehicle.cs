using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public bool IsParked { get; set; }
        public bool IsInReverse { get; set; }
        public void Drive();
        public void Park();
        public void Reverse();
    }
}
