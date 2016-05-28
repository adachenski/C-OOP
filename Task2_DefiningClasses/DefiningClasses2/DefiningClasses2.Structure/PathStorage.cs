namespace DefiningClasses2.Structure
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        public static void SaveToFile(Path currentPath)
        {
            StreamWriter file = new StreamWriter("../../point3D.txt");
            var count = 1;
            Console.WriteLine("========= Save To File Initiated ========");
            foreach (var item in currentPath.pointList)
            {
                file.WriteLine("Point "+count+": "+item.ToString());
                count++;
            }        
            file.Close();
        }

        public static void LoadFromFile(Path currentPath)
        {
            StreamReader file = new StreamReader("../../point3D.txt");
            Console.WriteLine("========= Load From File Initiated ========");
            foreach (var item in currentPath.pointList)
            {
                var fileInfo = file.ReadLine();
                Console.WriteLine(fileInfo);
            }
            file.Close();
        }
    }
}
