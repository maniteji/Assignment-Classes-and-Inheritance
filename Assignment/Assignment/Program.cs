using System;
using Assignment;

List<Appliance> appliances;     // All the appliance are stored inside this list.

// Loads the appliances from the file into the list.
appliances = LoadAppliances("./../../../Data/appliances.txt");


// Method to take the appliance number from the user and check it out if found
void PurchaseAppliance()
{
    Console.WriteLine("Enter item number of an Appliance: ");
    Console.Write("     ");
    string itemNumber = Console.ReadLine();
    foreach (var appliance in appliances)
    {
        if (appliance.ItemNumber.Equals(itemNumber))
        {
            Console.WriteLine($"Appliance \"{appliance.ItemNumber}\" has been checked out.");
            appliances.Remove(appliance);
            return;
        }
    }
    Console.WriteLine("No appliances found with that item number.\n");
}

// Method to search all the appliances of a given brand
void BrandSearch()
{
    Console.WriteLine("Enter brand to search for: ");
    Console.Write("     ");
    string brand = Console.ReadLine();

    if (brand == null)
    {
        Console.WriteLine("Invalid input, please try again.");
        return;
    }

    Console.WriteLine("Matching Appliances:");
    foreach (Appliance appliance in appliances)
    {
        if (appliance.Brand.ToUpper().Equals(brand.ToUpper()))
        {
            Console.WriteLine(appliance.ToString());
            Console.WriteLine();
        }
    }
}

// Load the appliance on the basis of type and their unique properties taken by user.
void TypeSearch()
{
    Console.WriteLine("Appliance Types");
    Console.WriteLine("1 – Refrigerators");
    Console.WriteLine("2 – Vacuums");
    Console.WriteLine("3 – Microwaves");
    Console.WriteLine("4 – Dishwashers");
    Console.WriteLine("Enter type of appliance: ");
    Console.Write("    ");

    // Check if the user entered an integer input.
    if (int.TryParse(Console.ReadLine(), out int applianceType))
    {
        if (applianceType == 1)
        {
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");
            Console.Write("    ");

            if (int.TryParse(Console.ReadLine(), out int numDoors))
            {
                Console.WriteLine("Matching refrigerators:");
                foreach (Appliance appliance in appliances)
                {
                    // print all the refrigerators with given number of doors.
                    if (appliance is Refrigerator && numDoors == ((Refrigerator)appliance).NumberOfDoors)
                    {
                        Console.WriteLine(appliance.ToString());
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number of doors.");
            }
        }
        else if (applianceType == 2)
        {
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high): ");
            Console.Write("    ");

            if (int.TryParse(Console.ReadLine(), out int batteryVoltageValue))
            {
                Console.WriteLine("Matching vacuums:");
                foreach (Appliance appliance in appliances)
                {
                    // print all the vacuums with given number of battery voltage.
                    if (appliance is Vacuum && batteryVoltageValue == ((Vacuum)appliance).BatteryVoltage)
                    {
                        Console.WriteLine(appliance.ToString());
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number of voltage value.");
            }
        }
        else if (applianceType == 3)
        {
            Console.WriteLine("RoomWhere the microwave will be installed: K (kitchen) or W (work site): ");
            Console.Write("    ");
            string room = Console.ReadLine();

            if (room == null || (!room.ToUpper().Equals("K") && !room.ToUpper().Equals("W")))
            {
                Console.WriteLine("Invalid type of room entered.");
            }
            else
            {
                Console.WriteLine("Matching microwaves:");
                foreach (Appliance appliance in appliances)
                {
                    // print all the microvaves with given room type.
                    if (appliance is Microwave && char.ToUpper(char.Parse(room)) == char.ToUpper(((Microwave)appliance).RoomType))
                    {
                        Console.WriteLine(appliance.ToString());
                        Console.WriteLine();
                    }
                }
            }
        }
        else if (applianceType == 4)
        {
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate): \n");
            Console.Write("    ");
            string sound = Console.ReadLine();

            if (sound == null || (!sound.ToUpper().Equals("QT") && !sound.ToUpper().Equals("QR") && !sound.ToUpper().Equals("QU") && !sound.ToUpper().Equals("M")))
            {
                Console.WriteLine("Invalid rating of dishwasher entered.");
            }
            else
            {
                Console.WriteLine("Matching dishwahers:");
                foreach (Appliance appliance in appliances)
                {
                    // print all the dish washers with given sound rating.
                    if (appliance is Dishwasher && sound.ToUpper().Equals(((Dishwasher)appliance).SoundRating.ToUpper()))
                    {
                        Console.WriteLine(appliance.ToString());
                        Console.WriteLine();
                    }
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid type selection.");
    }
}

// Method to load a number of random appliances taken from the user.
void RandomAppliances()
{
    Console.WriteLine("Enter number of appliances: ");
    Console.Write("     ");
    if (int.TryParse(Console.ReadLine(), out int appliancesNumber))
    {
        Random rnd = new Random();
        List<Appliance> randomAppliances = new List<Appliance>();

        for (int i = 0; i < appliancesNumber; i++)
        {
            if (appliances.Count < 1)
            {
                break;
            }
            int randomIndex = rnd.Next(appliances.Count);
            randomAppliances.Add(appliances[randomIndex]);
            appliances.Remove(appliances[randomIndex]);
        }

        foreach (Appliance appliance in randomAppliances)
        {
            Console.WriteLine(appliance.ToString());
            appliances.Add(appliance);
        }
    }
    else
    {
        Console.WriteLine("Invalid number of appliances entered.");
    }
}

/// Method to store the appliances inside the Appliances list to a file of given path
void SaveData()
{
    SaveAppliances("./../../../Data/appliances.txt", appliances);
}


/// Method to load appliances data from a 
List<Appliance> LoadAppliances(string filePath)
{
    List<Appliance> appliances = new List<Appliance>();
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] fields = line.Split(';');
            string itemNumber = fields[0];
            string brand = fields[1];
            int quantity = int.Parse(fields[2]);
            int wattage = int.Parse(fields[3]);
            string color = fields[4];
            decimal price = decimal.Parse(fields[5]);

            switch (itemNumber[0])
            {
                case '1': // Refrigerator
                    int numberOfDoors = int.Parse(fields[6]);
                    int height = int.Parse(fields[7]);
                    int width = int.Parse(fields[8]);
                    appliances.Add(new Refrigerator(itemNumber, brand, quantity, wattage, color, price, numberOfDoors, height, width));
                    break;
                case '2': // Vacuum
                    string grade = fields[6];
                    int batteryVoltage = int.Parse(fields[7].TrimEnd(';'));
                    appliances.Add(new Vacuum(itemNumber, brand, quantity, wattage, color, price, grade, batteryVoltage));
                    break;
                case '3': // Microwave
                    double capacity = double.Parse(fields[6]);
                    char roomType = char.Parse(fields[7].TrimEnd(';'));
                    appliances.Add(new Microwave(itemNumber, brand, quantity, wattage, color, price, capacity, roomType));
                    break;
                case '4': // Dishwasher
                case '5':
                    string feature = fields[6];
                    string soundRating = fields[7].TrimEnd(';');
                    appliances.Add(new Dishwasher(itemNumber, brand, quantity, wattage, color, price, soundRating, feature));
                    break;
                default:
                    Console.WriteLine($"Invalid item number: {itemNumber}");
                    break;
            }
        }
    }
    return appliances;
}

/// Method to save the appliances to a file
void SaveAppliances(string filePath, List<Appliance> appliances)
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        foreach (Appliance appliance in appliances)
        {
            string line;
            if (appliance is Refrigerator)
            {
                Refrigerator refrigerator = (Refrigerator)appliance;
                line = $"{refrigerator.ItemNumber};{refrigerator.Brand};{refrigerator.Quantity};{refrigerator.Wattage};{refrigerator.Color};{refrigerator.Price};{refrigerator.NumberOfDoors};{refrigerator.Height};{refrigerator.Width}";
            }
            else if (appliance is Vacuum)
            {
                Vacuum vacuum = (Vacuum)appliance;
                line = $"{vacuum.ItemNumber};{vacuum.Brand};{vacuum.Quantity};{vacuum.Wattage};{vacuum.Color};{vacuum.Price};{vacuum.Grade};{vacuum.BatteryVoltage}";
            }
            else if (appliance is Microwave)
            {
                Microwave microwave = (Microwave)appliance;
                line = $"{microwave.ItemNumber};{microwave.Brand};{microwave.Quantity};{microwave.Wattage};{microwave.Color};{microwave.Price};{microwave.Capacity};{microwave.RoomType}";
            }
            else if (appliance is Dishwasher)
            {
                Dishwasher dishwasher = (Dishwasher)appliance;
                line = $"{dishwasher.ItemNumber};{dishwasher.Brand};{dishwasher.Quantity};{dishwasher.Wattage};{dishwasher.Color};{dishwasher.Price};{dishwasher.Feature};{dishwasher.SoundRating}";
            }
            else
            {
                Console.WriteLine($"Invalid appliance type: {appliance.GetType().Name}");
                return;
            }

            writer.WriteLine(line);
        }
        Console.WriteLine("Data saved successfully.");
    }
}


string option = "0";

// Loop while the user does no enter the exit option (5).
while (option != "5")
{
    Console.WriteLine("Welcome to Modern Appliances!");
    Console.WriteLine("How May We Assist You?");
    Console.WriteLine("1 – Check out appliance");
    Console.WriteLine("2 – Find appliances by brand");
    Console.WriteLine("3 – Display appliances by type");
    Console.WriteLine("4 – Produce random appliance list");
    Console.WriteLine("5 – Save & exit");
    Console.WriteLine("Enter option: ");
    Console.Write("     ");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            // Perform the function to purchase an appliance.
            PurchaseAppliance();
            break;

        case "2":
            // Perform the function to search for appliance on the basis of brand.
            BrandSearch();
            break;

        case "3":
            // Perform the function to search for appliance on the basis of appliance type.
            TypeSearch();
            break;

        case "4":
            // Perform the function to display some random number of appliances.
            RandomAppliances();
            break;

        case "5":
            // Save the current appliances in the applianceManager.
            SaveData();
            break;

        default:
            // Display the error if the user enter any other wrong input.
            Console.WriteLine("Invalid choice entered, please try again.");
            break;
    }

    Console.WriteLine("\n");
}
Console.WriteLine("Thank you for using the system!");