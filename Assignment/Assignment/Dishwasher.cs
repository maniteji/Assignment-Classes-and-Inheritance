namespace Assignment
{
    public class Dishwasher : Appliance
    {

        public string SoundRating { get; set; } // Dishwasher sound quality.
        
        public string Feature { get; set; } // Dishwasher features.
        // Constructor of the dishwasher class.
        public Dishwasher(string itemNumber, string brand, int quantity, int wattage, string color, decimal price, string soundRating, string feature)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            SoundRating = soundRating;
            Feature = feature;
        }
        // Method to get the string dishwasher of the refrigerator object.
        override
        public string ToString()
        {
            string formatedOutput = "Item Number: " + ItemNumber + Environment.NewLine +
                "Brand: " + Brand + Environment.NewLine +
                "Quantity: " + Quantity + Environment.NewLine +
                "Wattage: " + Wattage + Environment.NewLine +
                "Color: " + Color + Environment.NewLine +
                "Price: " + Price + Environment.NewLine +
                "Feature: " + Feature + Environment.NewLine;
            if (SoundRating.Equals("Qt"))
            {
                formatedOutput += "SoundRating: Quietest" + Environment.NewLine;
            }
            else if (SoundRating.Equals("Qr"))
            {
                formatedOutput += "SoundRating: Quieter" + Environment.NewLine;
            }
            else
            {
                formatedOutput += "SoundRating: Moderate" + Environment.NewLine;
            }
            return formatedOutput;
        }
    }
}
