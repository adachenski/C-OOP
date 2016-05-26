namespace DefiningClasses_1.Phone
{
    public class Battery
    {
        internal double Model { get; set; }

        internal double HouersIdle { get; set; }

        internal double HouersTalk { get; set; }

        internal BatteryType BatteryType { get; set; }

        public Battery(double model, double houersIdle, double houersTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HouersIdle = houersIdle;
            this.HouersTalk = houersTalk;
            this.BatteryType = batteryType;
        }
    }
}
