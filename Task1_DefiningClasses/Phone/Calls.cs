namespace DefiningClasses_1.Phone
{
    using System;

    public class Calls
    {
        public DateTime Date { get; set; }

        public long DialledPhone { get; set; }

        public long DurationInSeconds { get; set; }

        public Calls()
        {

        }

        public Calls(DateTime date, long dialledPhones, long durationInSeconds)
        {
            this.Date = date;
            this.DialledPhone = dialledPhones;
            this.DurationInSeconds = durationInSeconds;
        }
    }
}
