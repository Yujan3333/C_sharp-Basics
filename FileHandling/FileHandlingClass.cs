using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileHandlingClass
    {
        
        public void CreateFileUsingFileStream()
        {
            string filepath = @"D:\DotNet.txt";
            FileStream fileStream = new FileStream(filepath, FileMode.Create);
        }
        
    }
}
