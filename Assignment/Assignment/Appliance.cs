namespace Assignment
{
    /// <summary>
    /// Appliance is the base class for other types of appliances.
    /// </summary>
    public abstract class Appliance
    {
        /// <summary>
        /// The unique value of the item.
        /// </summary>
        public string ItemNumber { get; set; }
        /// <summary>
        /// Brand of the appliance.
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Quantity of the appliance available in stock.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// The electric consuption by the appliance.
        /// </summary>
        public int Wattage { get; set; }
        /// <summary>
        /// The color of the appliance.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// The price of the appliance.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Constructor of the Appliance class.
        /// </summary>
        /// <param name="itemNumber">Unique appliance value</param>
        /// <param name="brand">Appliance brand</param>
        /// <param name="quantity">Appliance stock</param>
        /// <param name="wattage">Appliance electric consumption</param>
        /// <param name="color">Appliance color</param>
        /// <param name="price">Appliance price</param>
        public Appliance(string itemNumber, string brand, int quantity, int wattage, string color, decimal price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
        }
    }
}