using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.XmlFileOp
{
    /// <summary>
    /// Explicit Implementation
    /// </summary>
    public class XmlFileOperation : IFileOperation
    {
        void IFileOperation.AppendFile(string fileName)
        {
            Console.WriteLine($"File Appended {fileName}");
        }

        void IFileOperation.CreateFile(string fileName)
        {
            Console.WriteLine($"File Created {fileName}");
        }

        void IFileOperation.ReadFile(string fileName)
        {
            Console.WriteLine($"File Read {fileName}");
        }

        void IFileOperation.WriteFile(string fileName)
        {
            Console.WriteLine($"File Written {fileName}");
        }
    }
}
