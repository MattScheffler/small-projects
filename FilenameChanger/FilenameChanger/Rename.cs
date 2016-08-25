using System;
using System.IO;

namespace FilenameChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart = "";
            while (restart.ToLower() != "quit")
            {
                Console.WriteLine("Rename all files in a folder and move them to a new folder.");
                Console.WriteLine("Or keep them in the same folder by entering the same start and end path");
                Console.WriteLine("Warning: Original files in the starting folder are erased.");
                Console.WriteLine("Make sure the file path entered has a '\\' after the desired ending folder.");
                Console.WriteLine("Example: C:\\Users\\Name\\Documents\\folder\\");
                Console.WriteLine();
                try
                {
                    Console.Write("Starting path: ");
                    string startPath = Console.ReadLine();

                    Console.Write("Ending path: ");
                    string endPath = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter starting number for new filenames.");
                    Console.WriteLine("Each filename will be incremented by 1 after this.");
                    Console.Write("Number to start at for filenames: ");
                    double filename = double.Parse(Console.ReadLine());

                    Program.rename(startPath, endPath, filename);
                    Console.WriteLine("Done.");
                }
                //if the entered path does not exist
                catch (System.IO.DirectoryNotFoundException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Starting or ending folder does not exist.");
                }
                //if there is still a name conflict when start and end paths are the same
                catch (System.IO.IOException e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error: {0}", e.Message);
                }
                //if the starting filename entered isn't a number
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Starting filename must be a number.");
                }

                Console.WriteLine();
                Console.WriteLine("Press 'enter' key to select another file path, or type 'quit' to end.");
                restart = Console.ReadLine();
                Console.Clear();
            }
        }

        public static void rename(string startPath, string endPath, double filename)
        {
            //Two loops are used if the paths are the same, to try and avoid name conflicts
            if (startPath == endPath)
            {
                double newFilename = filename;

                string[] files = System.IO.Directory.GetFiles(@startPath);
                foreach (string file in files)
                {
                    File.Copy(file, endPath + filename.ToString() + "(COPY)" + Path.GetExtension(file));
                    File.Delete(file);
                    ++filename;
                }

                string[] copyFiles = System.IO.Directory.GetFiles(@endPath);
                foreach (string file in copyFiles)
                {
                    File.Copy(file, endPath + newFilename.ToString() + Path.GetExtension(file));
                    File.Delete(file);
                    ++newFilename;
                }
            }

            else
            {
                string[] files = System.IO.Directory.GetFiles(@startPath);
                foreach (string file in files)
                {
                    File.Copy(file, endPath + filename.ToString() + Path.GetExtension(file));
                    File.Delete(file);
                    ++filename;
                }
            }

        }
    }
}
