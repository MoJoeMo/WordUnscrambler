using System;
using System.IO;

namespace WordUnscrambler.Workers
{
    class FileReader
    {
        public string[] Read(string fileName)
        {
            string[] fileContent;
            try
            {
                fileContent = File.ReadAllLines(fileName);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in FileReader.Read(): {0}", ex);
            }
            return fileContent;
        }
    }
}
