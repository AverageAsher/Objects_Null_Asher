public class Computer : IBootUp
{
    public string Brand { get; set; }
    public string Type { get; set; }
    public bool IsOn { get; set; }

    public Computer(string brand, string type, bool isOn)
    {
        Brand = brand;
        Type = type;
        IsOn = isOn;
    }

    public void PowerOnOff()
    {
        IsOn = !IsOn;
        if (IsOn)
        {
            Console.WriteLine("The computer is booting up!");
        }
        else
        {
            Console.WriteLine("The computer is shutting down!");
        }
    }

    public override string ToString()
    {
        return $"This computer is made by {Brand} and is a {Type} computer.";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Computer))
            return false;

        Computer other = (Computer)obj;
        return Brand == other.Brand && Type == other.Type && IsOn == other.IsOn;
    }

    public override int GetHashCode()
    {
        return Brand.GetHashCode() ^ Type.GetHashCode() ^ IsOn.GetHashCode();
    }
}