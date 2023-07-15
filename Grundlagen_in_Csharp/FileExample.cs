using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grundlagen_in_Csharp
{
    internal class FileExample
    {

        public void writeInFile() 
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }   
       

    }
}
