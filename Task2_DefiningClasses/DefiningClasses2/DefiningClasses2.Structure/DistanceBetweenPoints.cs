namespace DefiningClasses2.Structure
{
    using System;

    public static class DistanceBetweenPoints
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            var d = Math.Pow((secondPoint.X - firstPoint.X), 2) +
                Math.Pow((secondPoint.Y - firstPoint.Y), 2) +
                Math.Pow((secondPoint.Z - firstPoint.Z), 2);
            Console.WriteLine(d);
            d = Math.Sqrt(d);
            return d;
        }
    }
}
