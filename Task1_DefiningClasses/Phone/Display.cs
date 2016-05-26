namespace DefiningClasses_1.Phone
{
    public class Display
    {
        internal protected int Size { get; set; }

        internal int NumberOfColors { get; set; }

        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
    }

}
