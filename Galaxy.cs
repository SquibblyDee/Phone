using System;

public class Galaxy : Phone, IRingable 
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    public string Ring() 
    {
        
        return "someshit";
    }
    
    public string Unlock() 
    {
        string stuff = "stuff";
        return stuff;
    }
    public override void DisplayInfo() 
    {
        Console.WriteLine("##################################");
        Console.WriteLine("");
        Console.WriteLine("##################################");
    }
}