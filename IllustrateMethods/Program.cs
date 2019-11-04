using System;
using System.IO;

namespace IllustrateMethods
{
    class Test
    {
        public static void Main(string[] args)
        {
            string path = Path.GetTempFileName();
            FileInfo fi1 = new FileInfo(path);
            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine("This is");
                sw.WriteLine("Sanfoundry");
                sw.WriteLine("Website");
            }
            using (StreamReader sr = fi1.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            try
            {
                string path2 = Path.GetTempFileName();
                FileInfo fi2 = new FileInfo(path2);
                fi2.Delete();
                fi1.CopyTo(path2);
                Console.WriteLine("{0} was copied to {1}.", path, path2);
                fi2.Delete();
                Console.WriteLine("{0} was successfully deleted.", path2);

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            Console.Read();
        }
    }
}
