namespace DefiningClasses_1
{
    using System;

    using DefiningClasses_1.Phone;

    public class Program
    {
        static void Main(string[] args)
        {
            int phonesCount = GSMTest.InitalValue = 20;
            var phoneGenerator = new GSMTest();
           
            var randomPhones = phoneGenerator.GeneratePhones();

            // for (int i = 0; i < phonesCount; i++)
            // {
            //     Console.WriteLine("Phone: {0}",i+1);
            //     randomPhones[i].ToString();
            // }

            var myPhone = randomPhones[12];
            var x = myPhone;
            var call = new Calls(DateTime.Now, 432234423, 321);
            x.AddCalss(call);
            
            
            
        }
    }
}
