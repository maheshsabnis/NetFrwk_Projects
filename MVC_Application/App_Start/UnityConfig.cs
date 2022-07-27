using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Application.Entities;
using Application.DataAccess;


namespace MVC_Application
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // DI Registration of the Dependencies
            container.RegisterType<IDataAccess<Department,int>, DepartmentDataAccess>();
            container.RegisterType<IDataAccess<Employee,int>, EmployeeDataAccess>();
            
            // Resolve and manage instances of all dependencies 
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}