using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO_OperationsPractice
{
    public class FileIO
    {
        public bool IsExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists");
                return true;
            }
            else
            {
                Console.WriteLine("File does not exists");
                return false;
            }
        }
    }
}
