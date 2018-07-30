            public abstract class Phone 
            {
                private string _versionNumber;
                private int _batteryPercentage;
                private string _carrier;
                private string _ringTone;
                public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone){
                    _versionNumber = versionNumber;
                    _batteryPercentage = batteryPercentage;
                    _carrier = carrier;
                    _ringTone = ringTone;
                }
                // abstract method. This method will be implemented by the subclasses
                public abstract void DisplayInfo();
                
                ////These gets grabs the values from our private variables and assigns them to a similarly named public vairable.
                public string versionNumber
                {
                    get => _versionNumber;
                }
                public int batteryPercentage
                { 
                    get => _batteryPercentage;
                }
                public string carrier
                { 
                    get => _carrier;
                }
                public string ringTone
                {
                    get => _ringTone;
                }
                
            }
        