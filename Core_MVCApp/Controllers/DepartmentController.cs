using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core_MVCApp.Models;
using Core_MVCApp.DataAccess;
namespace Core_MVCApp.Controllers
{
    /// <summary>
    /// Route Configuration
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IDataAccess<Department, int> deptds;
        public DepartmentController(IDataAccess<Department, int> deptds)
        {
            this.deptds = deptds;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var response = deptds.Get();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var response = deptds.Get(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Department dept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = deptds.Craete(dept);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(ModelState);
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Department dept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = deptds.Update(id,dept);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var response = deptds.Delete(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
