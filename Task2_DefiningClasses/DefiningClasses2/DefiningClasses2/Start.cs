namespace DefiningClasses2
{
    using Structure;
    using System;

    public class Start
    {
        static void Main(string[] args)
        {
            Point3D myPoint = new Point3D() { X = 5, Y = 32, Z = 43 };
         
            Console.WriteLine(myPoint.ToString());
        }
    }
}
