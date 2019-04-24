/* 
Program Function: Hello World. Output Name, Date and Time
Janelle Burt
ITDEV - 117-601
burtjm@gmatc.matc.edu
Date: 3-6-19
Version 1.0
 */

using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Janelle, "+ " " + DateTime.Now.ToString("MM/dd/yyyy H:mm"));
        }
    }
}
