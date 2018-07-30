using System;
public class Nokia : Phone, IRingable 
{
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            string returnString = this.ringTone;
            return returnString;
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