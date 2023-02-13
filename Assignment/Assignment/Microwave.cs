namespace Assignment
{
    public class Microwave : Appliance
    {
        /// <summary>
        /// Microwave room capacity.
        /// </summary>
        public double Capacity { get; set; }
        /// <summary>
        /// Microwave installation room type.
        /// </summary>
        public char RoomType { get; set; }

        /// <summary>
        /// Constructor of the microwave class.
        /// </summary>
        /// <param name="itemNumber">Unique microwave number</param>
        /// <param name="brand">microwave brand</param>
        /// <param name="quantity">microwave stock</param>
        /// <param name="wattage">microwave electric consumption</param>
        /// <param name="color">microwave color</param>
        /// <param name="price">microwave price</param>
        /// <param name="capacity">microwave room capacity</param>
        /// <param name="roomType">microwave installation room type</param>
        public Microwave(string itemNumber, string brand, int quantity, int wattage, string color, decimal price, double capacity, char roomType)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Capacity = capacity;
            RoomType = roomType;
        }

        /// <summary>
        /// Method to get the string microwave of the refrigerator object.
        /// </summary>
        /// <returns>formatted info of the microwave properties.</returns>
        override
        public string ToString()
        {
            string formatedOutput = "Item Number: " + ItemNumber + Environment.NewLine +
                "Brand: " + Brand + Environment.NewLine +
                "Quantity: " + Quantity + Environment.NewLine +
                "Wattage: " + Wattage + Environment.NewLine +
                "Color: " + Color + Environment.NewLine +
                "Price: " + Price + Environment.NewLine +
                "Capacity: " + Capacity + Environment.NewLine;
            if (RoomType == 'K')
            {
                formatedOutput += "Room Type: Kitchen" + Environment.NewLine;
            }
            else
            {
                formatedOutput += "Room Type: Work Site" + Environment.NewLine;
            }
            return formatedOutput;
        }
    }
}
