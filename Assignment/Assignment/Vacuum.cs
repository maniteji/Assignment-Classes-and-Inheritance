namespace Assignment
{
    public class Vacuum : Appliance
    {
        /// <summary>
        /// Grade of the vacuum.
        /// </summary>
        public string Grade { get; set; }
        /// <summary>
        /// The size battery in voltage.
        /// </summary>
        public int BatteryVoltage { get; set; }

        /// <summary>
        /// Constructor of the vacuum class.
        /// </summary>
        /// <param name="itemNumber">Unique vacuum number</param>
        /// <param name="brand">vacuum brand</param>
        /// <param name="quantity">vacuum stock</param>
        /// <param name="wattage">vacuum electric consumption</param>
        /// <param name="color">vacuum color</param>
        /// <param name="price">vacuum price</param>
        /// <param name="grade"></param>
        /// <param name="batteryVoltage"></param>
        public Vacuum(string itemNumber, string brand, int quantity, int wattage, string color, decimal price, string grade, int batteryVoltage)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Grade = grade;
            BatteryVoltage = batteryVoltage;
        }

        /// <summary>
        /// Method to get the string representation of the vacuum object.
        /// </summary>
        /// <returns>formatted info of the vacuum properties.</returns>
        override
        public string ToString()
        {
            string formatedOutput = "Item Number: " + ItemNumber + Environment.NewLine +
                "Brand: " + Brand + Environment.NewLine +
                "Quantity: " + Quantity + Environment.NewLine +
                "Wattage: " + Wattage + Environment.NewLine +
                "Color: " + Color + Environment.NewLine +
                "Price: " + Price + Environment.NewLine +
                "Grade: " + Grade + Environment.NewLine;

            if (BatteryVoltage == 18)
            {
                formatedOutput += "Battery voltage: Low" + Environment.NewLine;
            }
            else
            {
                formatedOutput += "Battery voltage: High" + Environment.NewLine;
            }
            return formatedOutput;
        }
    }
}
