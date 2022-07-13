using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.JsonFileOp
{
    public class JsonFileOperation : IFileOperation
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
