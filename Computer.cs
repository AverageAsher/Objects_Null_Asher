public class Computer : IBootUp
{
    // Public properties for the Computer class
    public string Brand { get; set; } // Holds the brand of the computer
    public string Type { get; set; }  // Holds the type of the computer (e.g., laptop, desktop)
    public bool IsOn { get; set; }    // Indicates whether the computer is currently on or off

    // Constructor to initialize the Computer object with brand, type, and power state
    public Computer(string brand, string type, bool isOn)
    {
        Brand = brand;  // Assigns the brand passed to the constructor to the Brand property
        Type = type;    // Assigns the type passed to the constructor to the Type property
        IsOn = isOn;    // Assigns the power state passed to the constructor to the IsOn property
    }

    // Method to toggle the power state of the computer
    public void PowerOnOff()
    {
        IsOn = !IsOn; // Toggles the power state (on/off)
        if (IsOn)     // If the computer is now on
        {
            Console.WriteLine("The computer is booting up!"); // Print boot up message
        }
        else          // If the computer is now off
        {
            Console.WriteLine("The computer is shutting down!"); // Print shut down message
        }
    }

    // Override of the ToString method to provide a string representation of the computer
    public override string ToString()
    {
        return $"This computer is made by {Brand} and is a {Type} computer.";
        // Returns a string describing the computer's brand and type
    }

    // Override of the Equals method to compare two Computer objects
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Computer)) // Check if the object is null or not a Computer
            return false;                      // If true, return false (not equal)

        Computer other = (Computer)obj; // Cast the object to a Computer type
        // Compare the Brand, Type, and IsOn properties to determine equality
        return Brand == other.Brand && Type == other.Type && IsOn == other.IsOn;
    }

    // Override of the GetHashCode method to provide a unique identifier for the object
    public override int GetHashCode()
    {
        // Generate a hash code by combining the hash codes of the Brand, Type, and IsOn properties
        return Brand.GetHashCode() ^ Type.GetHashCode() ^ IsOn.GetHashCode();
    }
}
