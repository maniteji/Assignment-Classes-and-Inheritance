using System.Security.Cryptography;

namespace Assignment
{
    /// <summary>
    /// Refrigerator class inheriting from Applaince class.
    /// </summary>
    public class Refrigerator : Appliance
    {
        /// <summary>
        /// Number of refrigerator doors.
        /// </summary>
        public int NumberOfDoors { get; set; }
        /// <summary>
        /// height of the refrigerator.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Width of the refrigerator.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Constructor of the refrigerator class.
        /// </summary>
        /// <param name="itemNumber">Unique refrigerator number</param>
        /// <param name="brand">refrigerator brand</param>
        /// <param name="quantity">refrigerator stock</param>
        /// <param name="wattage">refrigerator electric consumption</param>
        /// <param name="color">refrigerator color</param>
        /// <param name="price">refrigerator price</param>
        /// <param name="numberOfDoors">number of refrigerator doors</param>
        /// <param name="height">refrigerator height</param>
        /// <param name="width">refrigerator width</param>
        public Refrigerator(string itemNumber, string brand, int quantity, int wattage, string color, decimal price, int numberOfDoors, int height, int width)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            NumberOfDoors = numberOfDoors;
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Method to get the string representation of the refrigerator object.
        /// </summary>
        /// <returns>formatted info of the refrigerator properties.</returns>
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
