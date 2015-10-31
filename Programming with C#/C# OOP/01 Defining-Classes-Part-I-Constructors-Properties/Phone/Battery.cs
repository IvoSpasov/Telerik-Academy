namespace Phone
{
    using System;

    public class Battery
    {
        private readonly string model;
        private readonly BatteryType typeOfBattery;
        private double hoursIdle;
        private double hoursTalk;

        public Battery()
        {
        }

        public Battery(string batModel)
        {
            if (batModel == string.Empty)
            {
                throw new ArgumentNullException("Battery model can not be an empty string.");
            }
            this.model = batModel;
        }

        public Battery(string batModel, BatteryType batType)
            : this(batModel)
        {
            this.typeOfBattery = batType;
        }

        public Battery(string batModel, BatteryType batType, double batHoursIdle)
            : this(batModel, batType)
        {
            this.HoursIdle = batHoursIdle;
        }

        public Battery(string batModel, BatteryType batType, double batHoursIdle, double batHoursTalk)
            : this(batModel, batType, batHoursIdle)
        {
            this.HoursTalk = batHoursTalk;
        }

        public string Model
        {
            get { return this.model; }
        }

        public BatteryType TypeOfBattery
        {
            get { return this.typeOfBattery; }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value for hoursIdle can not be less than 0.");
                }

                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value for hoursTalk can not be less than 0.");
                }

                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            string template = "Battery model: {0}\nBattery type: {1}\nBattery idle hours: {2}\nBattery talk hours: {3}";
            string result = string.Format(template, this.model ?? "not abailable", typeOfBattery,
                this.hoursIdle, this.hoursTalk);
            return result;
        }
    }
}
