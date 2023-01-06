using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string Name { get; set; } = "Bat Mobile";
        public int Cost { get; set; } = 1000000;
        public bool Insured { get; set; } = true;
        public int Wheels { get; set; } = 4;
        public string Color { get; set; } = "Black";
        public string CompanyName { get; set; } = "Wayne Industries";
        public string Logo { get; set; } = "Bat Symbol";
        public int StartYear { get; set; } = 1950;
        public bool FourWheelDrive { get; set; } = true;
        public bool HasTrailerHitch { get; set; } = false;
        public void Display()
        {
            string message = $"The {Color} {Name} has {Wheels} wheels and costs ${Cost}.00. ";
            if (Insured == true) message += "It can be insured. ";
            if (Insured == false) message += "It can't be insured. ";
            if (FourWheelDrive == true) message += "It has 4-wheel drive. ";
            if (FourWheelDrive == false) message += "It lacks 4-wheel drive. ";
            if (HasTrailerHitch == true) message += "It has a trailer hitch. ";
            if (HasTrailerHitch == false) message += "It lacks a trailer hitch. ";
            Console.WriteLine(message);
        }
        public void History()
        {
            string message = "";
            message = $"{CompanyName} was founded in {StartYear} using the {Logo} as a logo.";
            Console.WriteLine(message);
        }
    }
}
