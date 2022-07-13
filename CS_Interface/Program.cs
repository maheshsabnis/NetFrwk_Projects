using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Interface.TextFileOp;
using CS_Interface.XmlFileOp;
using CS_Interface.JsonFileOp;
using CS_Interface.MultiInterfaces;
using CS_Interface.ClassnInterface;
namespace CS_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Interface");
            //TextFileOperation txtFile = new TextFileOperation();
            //txtFile.CreateFile("f.txt");
            //txtFile.WriteFile("f.txt");
            //txtFile.ReadFile("f.txt");
            //txtFile.AppendFile("f.txt");

            //IFileOperation fileOp = new XmlFileOperation();

            //fileOp.CreateFile("f.xml");
            //fileOp.WriteFile("f.xml");
            //fileOp.ReadFile("f.xml");
            //fileOp.AppendFile("f.xml");

            //Console.WriteLine();
            //fileOp = new JsonFileOperation();
            //fileOp.CreateFile("f.json");
            //fileOp.WriteFile("f.json");
            //fileOp.ReadFile("f.json");
            //fileOp.AppendFile("f.json");

            Gateway gate = new Gateway();
            IFileOperation fileOp = new TextFileOperation();
            gate.CompleteFileOperations(fileOp, "file.txt");
            fileOp = new XmlFileOperation();
            gate.CompleteFileOperations(fileOp,  "file.xml");
            fileOp = new JsonFileOperation();
            gate.CompleteFileOperations(fileOp, "file.json");

            IMath m1 = new Operation();
            Console.WriteLine($"Add = {m1.Add(20,30)}");
            INewMath m2 = new Operation();
            Console.WriteLine($"Add Square = {m2.Add(30,40)}");

            IMessage m = new MyDerive();
            m.DisplayMessage("Hello Interface");
            // Runtime (Execution-Time) is informed that the m can
            // point to the memory location for MyDerive so that 
            // PrintMessage() method from the Code-Segment can be invoked and executed
            // Dynamic-Polymorphism
            ((MyDerive)m).PrintMessage("Hello Base Class");



            Console.ReadLine();
        }
    }
}
