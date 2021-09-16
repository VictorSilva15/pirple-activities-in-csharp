using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystem_Part_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //USE the file class

            string path = @"C:\temp\testText.txt";
            string path2 = @"C:\temp\testText2.txt";

            //File.Exists checks if there is a file of such a name in such directory

            if (File.Exists(path))
            {
                //File.Delete(path)deletes such files from the directory
                File.Delete(path);
            }

            //File.WriteAllText()
            //Creates the file, allows us to write to it and then closes the file
            //if the file exists it will replace it


            
            File.WriteAllText(path, "Hello World");

            //File.WriteAllLines()
            //Create the file, allows us to write 1 or more lines and then closes the file
            //replaces existing files 
            File.WriteAllLines(path2, new string[] {"1° Linha do arquivo", "2° linha do arquivo", "3° linha do arquivo" });

            //editing the files -Appending to the files
            //File.AppendAllText()
            //opens file, append to it and the closes it
            File.AppendAllText(path, "\nHow's it going?");

            //Reading the File
            //File.ReadAllText returns a string
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
            Console.WriteLine(File.ReadAllText(path2));
            

            //Directory

            string dirPath = @"C:\temp\newDirectory";

            //Cannot exists

            if(Directory.Exists(dirPath))
            {
                //Deleting
                //Two ways
                //1 IF the directory is Empty
                //Directory.Delete(newPath);
                //2 IF the directory INST Empty
                Directory.Delete(dirPath, true);

            }
            Directory.CreateDirectory(dirPath);

            //Path class
            //Allow us to make changes to the string path that lead to directories or filess

            string newPath = @"C:\temp\newDirectory\ourText.txt";

            File.WriteAllText(newPath, "WOW this is really cool!");


            //gets directory Name
            string dirname = Path.GetDirectoryName(newPath);
            Console.WriteLine("Directory Name: " + dirname);

            //gets file extension
            string fileExt = Path.GetExtension(newPath);
            Console.WriteLine("File Extension: " + fileExt);

            //gets file name
            string fileName = Path.GetFileName(newPath);
            Console.WriteLine("File Name: " + fileName);

            //gets file name without extension 
            string file_woExt = Path.GetFileNameWithoutExtension(newPath);
            Console.WriteLine("File without Extension: " + file_woExt);

            //gets files root directory
            string root = Path.GetPathRoot(newPath);
            Console.WriteLine("Root directory: " + root);

            //change file extension
            string newFileRes = Path.ChangeExtension(newPath, "new");
            Console.WriteLine("new File: " + newFileRes);

            Console.ReadKey();
        }
    }
}
