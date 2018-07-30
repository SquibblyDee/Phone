using System;
public class Nokia : Phone, IRingable 
{
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        
        ////This returns a string of our ringtone
        public string Ring() 
        {
            string returnString = $"... {this.ringTone} ...";
            return returnString;
        }

        ////This returns our unlock string
        public string Unlock() 
        {
            string returnString = $"Nokia {this.versionNumber} unlocked with passcode";
            return returnString;
        }

        ////This displays all info on the currently targeted object
        public override void DisplayInfo() 
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"Nokia {this.versionNumber}");
            Console.WriteLine($"Battery Percentage: {this.batteryPercentage}");
            Console.WriteLine($"Carrier: {this.carrier}");
            Console.WriteLine($"Ring Tone: {this.ringTone}");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$\n");        
        }
}