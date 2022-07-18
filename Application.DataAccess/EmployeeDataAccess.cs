using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;
namespace Application.DataAccess
{
    public class EmployeeDataAccess : IDataAccess<Employee, int>
    {
        Employee IDataAccess<Employee, int>.Craete(Employee entity)
        {
            throw new NotImplementedException();
        }

        Employee IDataAccess<Employee, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Employee> IDataAccess<Employee, int>.Get()
        {
            throw new NotImplementedException();
        }

        Employee IDataAccess<Employee, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Employee IDataAccess<Employee, int>.Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
