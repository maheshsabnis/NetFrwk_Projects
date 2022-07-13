using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.TextFileOp
{
    /// <summary>
    /// The class is implementing Interface Implicitly
    /// </summary>
    public class TextFileOperation : IFileOperation
    {
        public void CreateFile(string fileName)
        {
            Console.WriteLine($"File Created {fileName}");
        }
        public void WriteFile(string fileName)
        {
            Console.WriteLine($"File Written {fileName}");
        }
        public void ReadFile(string fileName)
        {
            Console.WriteLine($"File Read {fileName}");
        }
        public void AppendFile(string fileName)
        {
            Console.WriteLine($"File Appended {fileName}");
        }
    }
}
