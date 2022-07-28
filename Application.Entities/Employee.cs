using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Application.Entities
{
    public class Employee
    {
        [Required(ErrorMessage = "EmpNo is Required")]
        [Remote("CheckIfEmpExist","Employee", ErrorMessage ="EmpNo is already Present")]
        public int EmpNo { get; set; }
        [Required(ErrorMessage = "EmpName is Required")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Designation is Required")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Salary is Required")]
        [NumericNonNegative (ErrorMessage = "Salary Cannot Be -ve")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "DeptNo is Required")]
        public int DeptNo { get; set; }
    }
}
