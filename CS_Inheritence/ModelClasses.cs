using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence
{
    /// <summary>
    /// Base class
    /// </summary>
    public class Employee
    {
        private int _EmpNo;
        private string _EmpName;
        private decimal _Salary;
        private string _DeptName;

        public Employee(int empNo, string empName, decimal salary, string deptName)
        {
            _EmpNo = empNo;
            _EmpName = empName;
            _Salary = salary;
            _DeptName = deptName;
        }

        //public decimal CalculateSalary()
        /// <summary>
        /// This will be only available to Employee class and derive class of Employee class
        /// </summary>
        /// <returns></returns>
        protected decimal CalculateSalary()
        {
            return _Salary;
        }
    }
    /// <summary>
    /// Manager is derived from Employee class
    /// The 'is-a' relationship
    /// </summary>
    public class Manager : Employee
    {
        // additional member of derived class
        decimal travelAllowance;

        /// <summary>
        /// Calling Base class ctor
        /// </summary>
        /// <param name="eno"></param>
        /// <param name="ename"></param>
        /// <param name="sal"></param>
        /// <param name="dname"></param>
        public Manager(int eno, string ename, decimal sal, string dname, decimal trallownace):base(eno, ename, sal, dname)
        {
            travelAllowance = trallownace;
        }

        /// <summary>
        /// Making  vritual menas the derive class can override this method
        /// </summary>
        /// <returns></returns>
        public virtual decimal GetSalary()
        {
            // call the Calculate Salary method of the base class and add allowance in it
            return CalculateSalary() + travelAllowance; 
        }
    }

    /// <summary>
    /// Multi-Level Inheritence
    /// </summary>
    public class SalesManager : Manager
    {
        decimal customerAllowance = 0;
        decimal hotelAllownace = 0;

        public SalesManager(int eno, string ename, decimal sal, string dname, decimal trallowance,  decimal customerAllowance, decimal hotelAllownace):base(eno,ename,sal,dname,trallowance)
        {
            this.customerAllowance = customerAllowance;
            this.hotelAllownace = hotelAllownace;
        }

        /// <summary>
        /// The base class method is overriden
        /// </summary>
        /// <returns></returns>
        public override decimal GetSalary()
        {
            return base.GetSalary() + customerAllowance + hotelAllownace;
        }
    }



    public class Engineer : Employee
    {
        // additional member of derived class
        int overTime;
        bool completeTask = false;

        /// <summary>
        /// Calling Base class ctor
        /// </summary>
        /// <param name="eno"></param>
        /// <param name="ename"></param>
        /// <param name="sal"></param>
        /// <param name="dname"></param>
        public Engineer(int eno, string ename, decimal sal, string dname, int ot) : base(eno, ename, sal, dname)
        {
             overTime = ot;
        }

        public decimal GetSalary(string status)
        {
            decimal otAllownace = 0;
            // call the Calculate Salary method of the base class and add allowance in it
            if (!IsTaskCompleted(status))
            {
                otAllownace = 0;
            }
            else
            {
                otAllownace = overTime * 5000;
            }
            return CalculateSalary() + otAllownace;
        }

        private bool IsTaskCompleted(string curStatus)
        { 
            if(curStatus == "In Progress" || curStatus == "Completed")
                    return true;
            return false;
        }
    }

}
