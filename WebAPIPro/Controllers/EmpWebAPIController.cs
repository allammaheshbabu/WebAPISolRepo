using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIPro.DataAcesses.DataRepository;
using WebAPIPro.DB_Context;
using WebAPIPro.Models;

namespace WebAPIPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpWebAPIController : ControllerBase
    {
        public IEmpRepository emprep;

        public EmpWebAPIController (IEmpRepository _emprep)
        {
        emprep = _emprep;

        }

        [HttpPost]
        [Route("InsertEmploye")]
        public async Task<IActionResult> InsertEmploye([FromBody] Employee Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var empres = await emprep.InsertEmployee(Emp);
                    if (empres > 0)
                    {
                        return Ok(empres);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }

        }
        [HttpDelete]
        [Route("DeleteEmploye")]
        public async Task<IActionResult> DeleteEmploye(int EmpNo)
        {
            try
            {
                var empres2 = await emprep.DeleteEmployee(EmpNo);
                if (empres2 > 0)
                {
                    return Ok(empres2);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("AllEmployees")]
        public async Task<IActionResult> AllEmployees()
        {
            try
            {
                var allemp = await emprep.GetAllEmployees();
                if (allemp.Count > 0)
                {
                    return Ok(allemp);
                }
                else
                {
                    return BadRequest();

                }
            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            } 

        }
        [HttpGet]
        [Route("GetEmpbyEmpId")]
        public async Task<IActionResult> GetEmpbyEmpId(int empId)
        {
            try { 
                
                var empbyid = await emprep.GetEmployeeById(empId);

                if (empbyid!=null)
                {
                    return Ok(empbyid);
                }
                else
                {
                    return BadRequest();
                }
            
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

        }
        [HttpPut]
        [Route("updateEmployee")]

        public  async Task<IActionResult> updateEmployee(Employee emp)
        {
            try
            {
                var upemp = await emprep.UpdateEmployee(emp);
                if (upemp > 0)
                {
                    return Ok(upemp);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }    
}
