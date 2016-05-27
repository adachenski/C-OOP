namespace DefiningClasses2.Structure
{
    using System;

    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D o;

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D O
        {
            get { return o; }
        }

        public Point3D(double x) : this()
        {

        }

        public override string ToString()
        {
            return String.Format("X = {0}, Y = {1}, Z = {2}", X, Y, Z);
        }

    }

}
