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
           // var x = DistanceBetweenPoints.CalculateDistance(myPoint, secondPoint);
           // Path c = new Path();
           // c.AddToPath(secondPoint);
           // c.AddToPath(myPoint);
           // PathStorage.SaveToFile(c);
           // PathStorage.LoadFromFile(c);

            GenericList<Point3D> genList = new GenericList<Point3D>(3);


            genList.AddElement(myPoint);
            genList.AddElement(secondPoint);

            
           var nas = genList.Min<Point3D>(myPoint, secondPoint);

           // var x2 = genList.FindElement(new Point3D {X=32,Y=144,Z=92 });
            Console.WriteLine("++++++++++++++++");
            //Console.WriteLine(x2);
            Console.WriteLine("++++++++++++++++");
            //genList.RemovingElement(0);
            //genList.InsertElement(1, "naskooo");



            //genList.RemoveElement(0);
            // genList.InsertToList(2, "Monster");
            //
            // genList.AddElement("ddd");
            // genList.RemoveElement(1);
            // genList.RemoveElement(3);
            // genList.RemoveElement(2);
            // genList.InsertToList(3, "doncho");
            // genList.AddElement("nasssssss");

            Console.WriteLine("=====================");

            foreach (var item in genList.elementContainer)
            {
                Console.WriteLine(item);
            }

        }
    }
}
