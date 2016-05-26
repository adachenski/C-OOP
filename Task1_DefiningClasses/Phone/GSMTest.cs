namespace DefiningClasses_1.Phone
{
    using System;

    public class GSMTest
    {
        public static int InitalValue { get; set; }

        private Random numberGen = new Random();

        private string[] phoneModels = { "T905", "9S", "M16", "RAZOR", "ENSINIUM", "NASKO" };
        private string[] phoneNames = { "Nokia", "IPhone", "Motorolla", "Samsung", "Sagem" };
        private string[] ownerName = { "Nasko", "Gosho", "Pesho", "Niki", "Kaloqn", "Micaela", "Ralitsa", "Oksana", "Marul", "Jhon" };
        BatteryType[] batteryValues = { BatteryType.Li_Ion, BatteryType.NiCD, BatteryType.NiMH };

        private GSM[] GSMArray = new GSM[InitalValue];

        public GSM[] GeneratePhonesTest()
        {
            for (int i = 0; i < GSMArray.Length; i++)
            {
                GSMArray[i] = new GSM(phoneModels[numberGen.Next(0, phoneModels.Length)],
                    phoneNames[numberGen.Next(0, phoneNames.Length)],
                    numberGen.Next(100, 3000), ownerName[numberGen.Next(0, ownerName.Length)],
                    new Battery(numberGen.Next(1000, 5000), numberGen.Next(1000, 5000), 
                    numberGen.Next(1000, 5000), batteryValues[numberGen.Next(0, 3)]),
                    new Display(numberGen.Next(4, 15), numberGen.Next(200, 2000000000)));

            }
            return GSMArray;
        }

        public void PrintPhones()
        {
            var arrPhones = GeneratePhonesTest();

            for (int i = 0; i < arrPhones.Length; i++)
            {
                Console.WriteLine("Phone: {0}", i + 1);
                arrPhones[i].ToString();
            }
        }
    }
}
