namespace DefiningClasses_1.Phone
{
    using System;

    public class CallHistoryTest
    {
        public static Battery testBattery = new Battery(123123, 120, 160, BatteryType.Li_Ion);

        public static Display testDisplay = new Display(9, 200000);

        public static GSM testPhone = new GSM("S9", "IPhone", 1200, "Snoopy", testBattery, testDisplay);

        public void TestPhone()
        {
            Calls firstCall = new Calls(DateTime.Now, 5086804301, 65);
            Calls secondCall = new Calls(DateTime.Now, 5308608619, 95);
            Calls thirdtCall = new Calls(DateTime.Now, 5086804301, 75);
            testPhone.AddCalss(firstCall);
            testPhone.AddCalss(secondCall);
            testPhone.AddCalss(thirdtCall);    
        }

        public void RemoveLongestCall()
        {
            var allCalls = testPhone.CallHistory;
            double longestCall = 0;
            Calls newCall =  new Calls();

            foreach (var item in allCalls)
            {
                double currentCall = item.DurationInSeconds;

                if (currentCall>longestCall)
                {
                    longestCall = currentCall;
                    newCall = item;
                }
            }
            testPhone.DeleteCalls(newCall);
        }

        public void ClearHistory()
        {
            testPhone.ClearHistory();
        }

        public override string ToString()
        {
            var allCalls = testPhone.CallHistory;
            var count = 1;
            foreach (var item in allCalls)
            {
                Console.WriteLine("Call {0}:\n Time of Call :{1}, Number called: {2}, Duration: {3}",
                count,item.Date, item.DialledPhone, item.DurationInSeconds);
                count++;
            }
            Console.WriteLine("Total Price for calls: {0}", testPhone.CallPrice());
            Console.WriteLine();
            return base.ToString();
        }
    }
}
