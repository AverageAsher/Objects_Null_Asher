public interface IBootUp
{
    // Property declaration in the interface, requires implementing classes to have a bool property named IsOn
    bool IsOn { get; set; }

    // Method declaration in the interface, requires implementing classes to define a PowerOnOff method
    void PowerOnOff();
}
