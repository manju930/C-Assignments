//C# Assignment
//Manjunath



using System;
using System.IO;

class FileIO
{
    public static void Main()
    {
        const filePath = @"C:\ManjuData.txt" 
        if (!File.Exists(filePath))
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("1111111111111111111111");
                sw.WriteLine("33333333333333333333333");
                sw.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(filePath))
        {
            //Printing file content to console.
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
        Console.WriteLine("Subdirectories under the path");
        getListSubDirectoryList(@"C:\Users");

        Console.WriteLine("press enter to continue");
        Console.ReadLine();
    }
    static void getListSubDirectoryList(string workingDirectoryPath)
    {
        string[] directories = Directory.GetDirectories(workingDirectoryPath);
        foreach (string d in directories)
        {
            Console.WriteLine(d);
        }
    }
}