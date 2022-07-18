using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entities
{
    /// <summary>
    /// The Class that is mapped with the Table
    /// This class will have public properties
    /// mapped with Column Names from the Department Table
    /// </summary>
    public class Department
    { 
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
    }
}
