namespace DefiningClasses2
{
    using Structure;
    using System;
    using System.Collections.Generic;
    public class Start
    {
        static void Main(string[] args)
        {
            Point3D myPoint = new Point3D(35, 14, 3);
            Point3D secondPoint = new Point3D(17, 6, 2);
            var x = DistanceBetweenPoints.CalculateDistance(myPoint, secondPoint);
            Path c = new Path();
            c.AddToPath(secondPoint);
            c.AddToPath(myPoint);
            PathStorage.SaveToFile(c);
            PathStorage.LoadFromFile(c);

            GenericList<string> genList = new GenericList<string>(4);

            genList.AddElement("Jhon");
            genList.AddElement("Jhon2");
            genList.AddElement("Jhon3");
            genList.AddElement("Jhon4");
            foreach (var item in genList.listOfElements)
            {
                Console.WriteLine(item);
            }
            var items = new List<string>();
            items.Add("Nasko");
            items.Add("Pesho");
            items.Add("Rally");
            items.Add("Minka");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(items.Count);
            items.Remove("Pesho");
            Console.WriteLine(items.Count);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
