namespace Assignment
{
    public class Vacuum : Appliance
    {
   
        public string Grade { get; set; }   /// Grade of the vacuum
        
        public int BatteryVoltage { get; set; }    // The size battery in voltage.

        /// Constructor of the vacuum class.
        public Vacuum(string itemNumber, string brand, int quantity, int wattage, string color, decimal price, string grade, int batteryVoltage)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Grade = grade;
            BatteryVoltage = batteryVoltage;
        }

        /// Method to get the string representation of the vacuum object.
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
