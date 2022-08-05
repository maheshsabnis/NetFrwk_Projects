using System.ComponentModel.DataAnnotations;

namespace Core_MVCApp.Models
{
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

    public class Employee
    {
        [Required(ErrorMessage = "EmpNo is Required")]
        public int EmpNo { get; set; }
        [Required(ErrorMessage = "EmpName is Required")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Designation is Required")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Salary is Required")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "DeptNo is Required")]
        public int DeptNo { get; set; }
    }
}
