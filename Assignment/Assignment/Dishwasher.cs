namespace Assignment
{
    public class Dishwasher : Appliance
    {
        /// <summary>
        /// Dishwasher sound quality.
        /// </summary>
        public string SoundRating { get; set; }
        /// <summary>
        /// Dishwasher features.
        /// </summary>
        public string Feature { get; set; }

        /// <summary>
        /// Constructor of the dishwasher class.
        /// </summary>
        /// <param name="itemNumber">Unique dishwasher number</param>
        /// <param name="brand">dishwasher brand</param>
        /// <param name="quantity">dishwasher stock</param>
        /// <param name="wattage">dishwasher electric consumption</param>
        /// <param name="color">dishwasher color</param>
        /// <param name="price">dishwasher price</param>
        /// <param name="soundRating">dishwasher sound quality</param>
        /// <param name="feature">dishwasher features</param>
        public Dishwasher(string itemNumber, string brand, int quantity, int wattage, string color, decimal price, string soundRating, string feature)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            SoundRating = soundRating;
            Feature = feature;
        }

        /// <summary>
        /// Method to get the string dishwasher of the refrigerator object.
        /// </summary>
        /// <returns>formatted info of the dishwasher properties.</returns>
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
