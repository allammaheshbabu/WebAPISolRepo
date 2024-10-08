using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAPIPro.DataAcesses.DataRepository;
using WebAPIPro.Models;

namespace WebAPIPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptWebAPIController : ControllerBase
    {

        public IDeptRepository deptrespository;
        public DeptWebAPIController(IDeptRepository _deptrespository) 
        {
            deptrespository = _deptrespository;
        }

        [HttpPost]
        [Route("InsertDepartment")]
        public  async Task<IActionResult> InsertDepartment(Department Dept)
        {
            try
            {
                var count= await deptrespository.InsertDepartment(Dept);
                if (count > 0)
                {
                    return Ok(count);
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
        [Route("AllDepartment")]
        public  async Task<IActionResult> AllDepartment()
        {
            try
            {
              var result= await deptrespository.AllDepartments();
                if (result.Count > 0)
                {
                    return Ok(result);
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
        [Route("GetDepartmentByDeptNo")]
        public async Task<IActionResult> GetDepartmentByDeptNo(int DeptNo)
        {
            try
            {
                var res = await deptrespository.GetDepartmentByDeptNo(DeptNo);
                if (res!=null)
                {
                    return Ok(res);
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
        [Route("UpdateDepartment")]
        public async Task<IActionResult> UpdateDepartment(Department Dept)
        {
            try
            {
                var res2 = await deptrespository.UpdateDepartment(Dept);
                if (res2 > 0)
                {
                    return Ok(res2);
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

        [HttpDelete]
        [Route("DeleteDepartment")]
        public async Task<IActionResult> DeleteDepartment(int DeptNo)
        {
            try
            {   
                var res2 = await deptrespository.DeleteDepartment(DeptNo);
                if (res2 > 0)
                {
                    return Ok(res2);
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
