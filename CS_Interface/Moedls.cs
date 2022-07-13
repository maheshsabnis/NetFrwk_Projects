using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface
{
    public interface IFileOperation
    {
        void CreateFile(string fileName);
        void WriteFile(string fileName);
        void ReadFile(string fileName);
        void AppendFile(string fileName);
    }


    public class Gateway
    {
        /// <summary>
        /// This method will dynamically decide about what class will be used to work with files 
        /// Dynamic Polymorphism using Interface
        /// </summary>
        /// <param name="fileop"></param>
        /// <param name="fileName"></param>
        public void CompleteFileOperations(IFileOperation fileop, string fileName)
        {
            fileop.CreateFile(fileName);
            fileop.WriteFile(fileName);
            fileop.ReadFile(fileName);
            fileop.AppendFile(fileName);
        }
    }
}
