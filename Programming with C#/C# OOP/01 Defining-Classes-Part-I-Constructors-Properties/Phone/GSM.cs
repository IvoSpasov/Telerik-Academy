
namespace Phone
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private readonly string model;
        private readonly string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private static readonly GSM iPhone4S = new GSM("iPhone4S", "Apple", 999, "Wolfgang Mozart",
            new Battery("US1445APPC", BatteryType.LiIon, 200, 8), new Display("3.5 inch", "16M"));
        private List<Call> history;

        public GSM(string gsmModel, string gsmManufac)
        {
            if (string.IsNullOrEmpty(gsmModel))
            {
                throw new ArgumentNullException("The model of the phone can not be null or an empty string.");
            }

            if (string.IsNullOrEmpty(gsmManufac))
            {
                throw new ArgumentNullException("The manufacturer of the phone can not be null or an empty string.");
            }

            this.model = gsmModel;
            this.manufacturer = gsmManufac;
            this.Battery = new Battery();
            this.Display = new Display();
            this.CallHistory = new List<Call>();
        }

        public GSM(string gsmModel, string gsmManufact, double gsmPrice)
            : this(gsmModel, gsmManufact)
        {
            this.Price = gsmPrice;
        }

        public GSM(string gsmModel, string gsmManufact, double gsmPrice, string gsmOwner)
            : this(gsmModel, gsmManufact, gsmPrice)
        {
            this.Owner = gsmOwner;
        }

        public GSM(string gsmModel, string gsmManufact, double gsmPrice, string gsmOwner, Battery gsmBattery)
            : this(gsmModel, gsmManufact, gsmPrice, gsmOwner)
        {
            this.Battery = gsmBattery;
        }

        public GSM(string gsmModel, string gsmManufact, double gsmPrice, string gsmOwner, Battery gsmBattery, Display gsmDisplay)
            : this(gsmModel, gsmManufact, gsmPrice, gsmOwner, gsmBattery)
        {
            this.Display = gsmDisplay;
        }

        public string Model
        {
            get { return this.model; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("The value for owner can not be an empty string.");
                }

                this.owner = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public List<Call> CallHistory
        {
            get { return this.history; }
            set { this.history = value; }
        }

        public void AddCall(Call newCall)
        {
            history.Add(newCall);
        }

        public void DeleteCall(Call oldCall)
        {
            history.Remove(oldCall);
        }

        public void ClearHistory()
        {
            history.Clear();
        }

        public double CalculateTotalPrice(double price)
        {
            double sum = 0;

            foreach (var call in history)
            {
                sum += call.Duration;
            }

            return sum * price;
        }

        public override string ToString()
        {
            string template = "Information about a cell phone:\n" +
                              "Manufacturer: {0}\nModel: {1}\nPrice: {2}\nOwner: {3}\n{4}\n{5}";
            string result = String.Format(template, this.manufacturer, this.model, this.price,
                this.owner ?? "not available", this.battery.ToString(), this.display.ToString());
            return result;
        }
    }
}
