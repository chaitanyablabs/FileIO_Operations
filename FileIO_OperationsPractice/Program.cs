using System;

namespace FileIO_OperationsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"G:\BridgeLabz\New folder\FileIO_Operations\FileIO_OperationsPractice\Files\Test.txt";

            FileIO fileIO = new FileIO();

            fileIO.IsExists(filePath);
        }
    }
}
