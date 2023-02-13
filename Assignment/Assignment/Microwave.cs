namespace Assignment
{
    public class Microwave : Appliance
    {

        public double Capacity { get; set; }    // Microwave room capacity.

        public char RoomType { get; set; }  // Microwave installation room type.

        public Microwave(string itemNumber, string brand, int quantity, int wattage, string color, decimal price, double capacity, char roomType)
            : base(itemNumber, brand, quantity, wattage, color, price)  // Constructor of the microwave class.
        {
            Capacity = capacity;
            RoomType = roomType;
        }

        // Method to get the string microwave of the refrigerator object.
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
