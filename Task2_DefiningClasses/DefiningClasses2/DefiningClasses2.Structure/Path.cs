namespace DefiningClasses2.Structure
{
    using System.Collections.Generic;

    public class Path
    {
        internal ICollection<Point3D> pointList = new List<Point3D>();

        public void AddToPath( Point3D newPoint)
        {
            this.pointList.Add(newPoint);
        }
    }
}
