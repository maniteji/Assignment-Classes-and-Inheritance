using System.Security.Cryptography;

namespace Assignment
{
    public class Refrigerator : Appliance
    {
        public int NumberOfDoors { get; set; }  // Number of refrigerator doors.

        public int Height { get; set; } // height of the refrigerator.

        public int Width { get; set; }  // Width of the refrigerator.

        /// Constructor of the refrigerator class.

        public Refrigerator(string itemNumber, string brand, int quantity, int wattage, string color, decimal price, int numberOfDoors, int height, int width)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            NumberOfDoors = numberOfDoors;
            Height = height;
            Width = width;
        }

        /// Method to get the string representation of the refrigerator object.
        override
        public string ToString()
        {
            string formatedOutput = "Item Number: " + ItemNumber + Environment.NewLine +
                "Brand: " + Brand + Environment.NewLine +
                "Quantity: " + Quantity + Environment.NewLine +
                "Wattage: " + Wattage + Environment.NewLine +
                "Color: " + Color + Environment.NewLine +
                "Price: " + Price + Environment.NewLine;
            if (NumberOfDoors == 2)
            {
                formatedOutput += "Number of Doors: Double Doors" + Environment.NewLine;
            }
            else if (NumberOfDoors == 3)
            {
                formatedOutput += "Number of Doors: Three Doors" + Environment.NewLine;
            }
            else
            {
                formatedOutput += "Number of Doors: Four Doors" + Environment.NewLine;
            }

            formatedOutput += "Height: " + Height + Environment.NewLine +
                "Width: " + Width + Environment.NewLine;
            return formatedOutput;
        }
    }
}
