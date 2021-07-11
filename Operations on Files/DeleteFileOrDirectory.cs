using System;
using System.IO;

namespace DeleteFileOrDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFileOrDirectory;
            string pathOfUserFileOrDir;
            string userDelConfirmation;

            Console.WriteLine("What would You like to delete: directory/file ?");
            userFileOrDirectory = Console.ReadLine();
            try
            {
                if (userFileOrDirectory == "directory")
                {
                    Console.WriteLine("Write the path of the directory");
                    pathOfUserFileOrDir = Console.ReadLine();
                    DirectoryInfo directory = new DirectoryInfo(pathOfUserFileOrDir);
                   
                    if (Directory.Exists(pathOfUserFileOrDir))
                    {
                        Console.WriteLine("Are You sure of deletion: " + pathOfUserFileOrDir + " yes/no ?");
                        userDelConfirmation = Console.ReadLine();
                        if (userDelConfirmation == "yes")
                        {
                            directory.Delete();
                            Console.WriteLine("Directory successfully deleted");
                        }
                        else if (userDelConfirmation == "no")
                        {
                            Console.WriteLine("Directory not deleted");
                        }
                        else
                        {
                            Console.WriteLine("Cannot delete the directory");
                        }
                    }
                }
                else if (userFileOrDirectory == "file")
                {
                    Console.WriteLine("Write the path of the file");
                    pathOfUserFileOrDir = Console.ReadLine();
                    FileInfo file = new FileInfo(pathOfUserFileOrDir);
                    
                    if (File.Exists(pathOfUserFileOrDir))
                    {
                        Console.WriteLine("Are You sure of deletion: " + pathOfUserFileOrDir + " yes/no ?");
                        userDelConfirmation = Console.ReadLine();
                        if (userDelConfirmation == "yes")
                        {
                            file.Delete();
                            Console.WriteLine("File successfully deleted");
                        }
                        else if (userDelConfirmation == "no")
                        {
                            Console.WriteLine("File not deleted");
                        }
                        else
                        {
                            Console.WriteLine("Cannot delete the file");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Directory or file only possible to delete");
                }
            } catch (Exception exc)
            {
                exc.ToString();
            }
        }   
    }
}
