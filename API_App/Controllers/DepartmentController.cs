using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Entities;
using Application.DataAccess;
namespace API_App.Controllers
{

    public class DepartmentController : ApiController
    {
        // USe the Dependency
        IDataAccess<Department, int> deptDbServ;
        /// <summary>
        /// Inject the depednency
        /// </summary>
        public DepartmentController(IDataAccess<Department,int> Serv)
        {
            deptDbServ = Serv;
        }

        // The HTTP Action Methods
        /// <summary>
        /// http://myserver/api/Department
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            try
            {
                var departments = deptDbServ.Get();
                return Ok(departments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// http://myserver/api/Department/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(int id)
        {
            try
            {
                var department = deptDbServ.Get(id);
                if (department == null)
                {
                    return NotFound();
                }       
                return Ok(department);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// The post request
        ///  http://myserver/api/Department/
        ///  The 'dept' will be send by the Client using Http Request Bosy as 'json' by default
        /// </summary>
        /// <returns></returns
        public IHttpActionResult Post(Department dept)
        {
            try
            {
                // Check for Model Validation
                if (ModelState.IsValid)
                {
                    var Response = deptDbServ.Craete(dept);
                    return Ok(Response);
                }
                else
                {
                    // Send the Error Response to the Client
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Error Ocurred while posting the request {ex.Message}");
            }
        }

        /// <summary>
        /// The put request
        ///  http://myserver/api/Department/{id}
        ///  The 'dept' will be send by the Client using Http Request Bosy as 'json' by default
        /// </summary>
        /// <returns></returns
        public IHttpActionResult Put(int id, Department dept)
        {
            try
            {
                // Check for Model Validation
                if (ModelState.IsValid)
                {
                    var Response = deptDbServ.Update(id,dept);
                    return Ok(Response);
                }
                else
                {
                    // Send the Error Response to the Client
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Error Ocurred while posting the request {ex.Message}");
            }
        }

        /// <summary>
        /// Delete a record based on id
        /// http://myserver/api/Department/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var department = deptDbServ.Delete(id);
                if (department == null)
                {
                    return NotFound();
                }
                return Ok(department);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
