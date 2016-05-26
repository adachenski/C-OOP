namespace DefiningClasses_1
{
    using DefiningClasses_1.Phone;

    public class Start
    {
        static void Main(string[] args)
        {
            //InitialValue is number of phones you want to create
            GSMTest.InitalValue = 10;
            var phoneGenerator = new GSMTest();

           //creating random phones
            phoneGenerator.GeneratePhonesTest();
            phoneGenerator.PrintPhones();

            var myCalls = new CallHistoryTest();
            //Creating phone with 3 calls in it
            myCalls.TestPhone();
            myCalls.ToString();

            //Removing the Longest Call from the History plus friendly messege
            myCalls.RemoveLongestCall();
            myCalls.ToString();

            //Clear all the calls from the history
            myCalls.ClearHistory();
            myCalls.ToString();           
        }
    }
}
