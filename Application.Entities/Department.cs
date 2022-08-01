using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Application.Entities
{
    /// <summary>
    /// The Class that is mapped with the Table
    /// This class will have public properties
    /// mapped with Column Names from the Department Table
    /// </summary>
    public class Department
    {
        [Required(ErrorMessage = "DeptNo is Required")]
        public int DeptNo { get; set; }
        [Required(ErrorMessage = "DeptName is Required")]
        public string DeptName { get; set; }
        [Required(ErrorMessage = "Location is Required")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Capacity is Required")]
        public int Capacity { get; set; }
    }
}
