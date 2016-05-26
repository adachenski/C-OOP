using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses_1.Phone
{
    public class CallHistoryTest
    {
        public static Battery testBattery = new Battery(123123, 120, 160, BatteryType.Li_Ion);

        public static Display testDisplay = new Display(9, 200000);

        public static GSM testPhone = new GSM("S9", "IPhone", 1200, "Snoopy", testBattery, testDisplay);

        public void TestPhone()
        {
           
        }
    }
}
