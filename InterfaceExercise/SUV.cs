using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string Name { get; set; } = "Waste of Money";
        public int Cost { get; set; } = 9000;
        public bool Insured { get; set; } = true;
        public int Wheels { get; set; } = 4;
        public string Color { get; set; } = "Gray";
        public string CompanyName { get; set; } = "A Bankrupt LLC";
        public string Logo { get; set; } = "Stereotypical Mini Van";
        public int StartYear { get; set; } = 2000;
        public bool FourWheelDrive { get; set; } = false;
        public int NumberOfSeats { get; set; } = 8;
        public void Display()
        {
            string message = $"The {Color} {Name} has {Wheels} wheels and costs ${Cost}.00. ";
            if (Insured == true) message += "It can be insured. ";
            if (Insured == false) message += "It can't be insured. ";
            if (FourWheelDrive == true) message += "It has 4-wheel drive. ";
            if (FourWheelDrive == false) message += "It lacks 4-wheel drive. ";
            message += $"It has a total of {NumberOfSeats} seats.";
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
