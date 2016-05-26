namespace DefiningClasses_1.Phone
{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        private string Model { get; set; }

        private string Manufacturer { get; set; }

        private double? Price { get; set; }

        private string Owner { get; set; }

        private Battery BatteryCharacteristics { get; set; }

        private Display DisplayCharecteristics { get; set; }

        public ICollection<Calls> CallHistory { get; set; }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double? price, string owner,
            Battery batteryCharacteristics, Display displayCharecteristics)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatteryCharacteristics = batteryCharacteristics;
            this.DisplayCharecteristics = displayCharecteristics;
            this.CallHistory = new List<Calls>();
        }

        public  void AddCalss(Calls call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCalls(Calls call)
        {
            CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.CallHistory = new List<Calls>();
        }

        public override string ToString()
        {
            Console.WriteLine("Model: {0}, Manufacturer: {1}, Price: {2}," +
               "\nOwner: {3}, Battery Model {4}, Battery Houers-Idle: {5},\n" +
               "Battery Houers-Talk: {6}, Battet-Type: {7},\nDisplay Size: {8}, Display Number Of Colors: {9} \n\n",
               this.Model, this.Manufacturer, this.Price, this.Owner, this.BatteryCharacteristics.Model, this.BatteryCharacteristics.HouersIdle,
               this.BatteryCharacteristics.HouersTalk, this.BatteryCharacteristics.BatteryType,
               this.DisplayCharecteristics.Size, this.DisplayCharecteristics.NumberOfColors);

            return string.Format("Model: {0}, Manufacturer: {1}, Price: {2}" +
                ",\n Owner: {3}, Battery Model {4}, Battery Houers-Idle: {5},\n" +
                "Battery Houers-Talk: {6}, Battet-Type: {7},\n Display Size: {8}, Display Number Of Colors: {9}",
                this.Model, this.Manufacturer, this.Price, this.Owner, this.BatteryCharacteristics.Model, this.BatteryCharacteristics.HouersIdle,
                this.BatteryCharacteristics.HouersTalk, this.BatteryCharacteristics.BatteryType,
                this.DisplayCharecteristics.Size, this.DisplayCharecteristics.NumberOfColors);
        }
    }
}
