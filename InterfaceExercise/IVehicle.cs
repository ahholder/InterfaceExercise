using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public bool Insured { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }
        public void Display();
    }
}
