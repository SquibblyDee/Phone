using System;

public class Galaxy : Phone, IRingable 
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    public string Ring() 
    {
        string returnString = $"... {this.ringTone} ...";
        return returnString;
    }
    
    public string Unlock() 
    {
        string returnString = $"Galaxy {this.versionNumber} unlocked with fingerprint scanner";
        return returnString;
    }
    public override void DisplayInfo() 
    {
        Console.WriteLine("#########################");
        Console.WriteLine($"Galaxy {this.versionNumber}");
        Console.WriteLine($"Battery Percentage: {this.batteryPercentage}");
        Console.WriteLine($"Carrier: {this.carrier}");
        Console.WriteLine($"Ring Tone: {this.ringTone}");
        Console.WriteLine("#########################\n");
    }
}