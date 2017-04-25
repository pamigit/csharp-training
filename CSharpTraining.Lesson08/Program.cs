using System;
using System.IO;

namespace CSharpTraining.Lesson08       // VS will create a namespace for your class (by default it will be the project name)
{
    class Program
    {
        static void Main()
        {
            var counter = 0;
            var line = "";

            FileStream fileStream = null;
            StreamReader reader = null;
            try
            {
                fileStream = new FileStream("sinput.txt", FileMode.Open);
                reader = new StreamReader(fileStream);

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }

                if (reader != null)
                {
                    reader.Dispose();
                }
            }

            //try
            //{
            //    using (var fileStream = new FileStream("sinput.txt", System.IO.FileMode.Open))
            //    {
            //        using (var reader = new StreamReader(fileStream))
            //        {
            //            while ((line = reader.ReadLine()) != null)
            //            {
            //                Console.WriteLine(line);
            //                counter++;
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

            Console.WriteLine("\nThere were {0} lines.", counter);

            // This line will prevent the console window from closing immediately.
            Console.ReadLine();
        }
    }
}