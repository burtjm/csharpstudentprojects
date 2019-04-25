/*
Janelle Burt
3/27/19
ITDEV 117
Assignment Week 7

 */
using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Directories
{

    class Program
    {
        static void Main(string[] args)

        
        {
            listFilesInDirectory(@"C:\Users\Owner\Downloads");
           
        }

        static void listFilesInDirectory(string workingDirectory)

        
        {
        string[] filePaths = Directory.GetFiles(workingDirectory);
        var stopWatch = Stopwatch.StartNew(); 

        using (StreamWriter sw = new StreamWriter("dirs.txt"))
            {
            foreach (string filepath in filePaths)
            {
                Console.WriteLine(filepath +
                DateTime.Now);
                sw.WriteLine(filepath +
                DateTime.Now);
                Console.Read();

            }
            }

            Console.WriteLine("foreach execution time = {0} seconds\n", stopWatch.Elapsed.TotalSeconds);


        }

    }
}

