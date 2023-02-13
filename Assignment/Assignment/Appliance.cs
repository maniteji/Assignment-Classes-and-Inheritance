namespace Assignment
{

    public abstract class Appliance
    {
        
        public string ItemNumber { get; set; }    // The unique value of the item.

        public string Brand { get; set; }   // Brand of the appliance.

        public int Quantity { get; set; }    // Quantity of the appliance available in stock.

        public int Wattage { get; set; }     // The electric consuption by the appliance.
        
        public string Color { get; set; }   // The price of the appliance.

        public decimal Price { get; set; }

        /// Constructor of the Appliance class.
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