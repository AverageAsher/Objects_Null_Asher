class Program
{
    static void Main(string[] args)
    {
        // Create a new Computer object
        Computer myComputer = new Computer("Dell", "Laptop", false);

        // Create an IBootUp object and assign it the computer object
        IBootUp bootableDevice = myComputer;

        // Compare the two using Equals and print the results
        Console.WriteLine("Comparing myComputer to bootableDevice: " + myComputer.Equals(bootableDevice));

        // Create another Computer object with the same values
        Computer anotherComputer = new Computer("Dell", "Laptop", false);

        // Compare the two Computer objects and print the results
        Console.WriteLine("Comparing myComputer to anotherComputer: " + myComputer.Equals(anotherComputer));

        // Create a new string variable using ToString
        string computerDescription = myComputer.ToString();

        // Compare the string variable to the object you used to create it
        Console.WriteLine("Comparing computerDescription to myComputer.ToString(): " + computerDescription.Equals(myComputer.ToString()));

        // Compare the string variable to another object
        Console.WriteLine("Comparing computerDescription to anotherComputer.ToString(): " + computerDescription.Equals(anotherComputer.ToString()));

        // Call GetType on a computer object and print the results
        Console.WriteLine("Type of myComputer: " + myComputer.GetType());

        // Call GetType on the IBootUp object and print the results
        Console.WriteLine("Type of bootableDevice: " + bootableDevice.GetType());

        // Turn on or off one of the computer objects
        myComputer.PowerOnOff();

        // Check if the string variable contains the letter "i"
        Console.WriteLine("Does computerDescription contain 'i'? " + computerDescription.Contains("i"));

        // Call ToUpper on the string variable and print the results
        Console.WriteLine("computerDescription in uppercase: " + computerDescription.ToUpper());
    }
}