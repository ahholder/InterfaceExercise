using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string Name { get; set; } = "Talking Truck from 'Cars'";
        public int Cost { get; set; } = 20000;
        public bool Insured { get; set; } = false;
        public int Wheels { get; set; } = 18;
        public string Color { get; set; } = "Red and White";
        public string CompanyName { get; set; } = "Pixar";
        public string Logo { get; set; } = "Sentient Lamp";
        public int StartYear { get; set; } = 1995;
        public bool HasTrailerHitch { get; set; } = true;
        public bool RequiresCDL { get; set; } = false;
        public void Display()
        {
            string message = $"The {Color} {Name} has {Wheels} wheels and costs ${Cost}.00. ";
            if (Insured == true) message += "It can be insured. ";
            if (Insured == false) message += "It can't be insured. ";
            if (RequiresCDL == true) message += "Its driver requires a CDL. ";
            if (RequiresCDL == false) message += "Its driver doesn't require a CDL. ";
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
