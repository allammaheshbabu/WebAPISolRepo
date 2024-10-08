using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicController : ControllerBase
    {
        [HttpGet]
        [Route("operations")]
        public IActionResult operations(int x, int y, string s)
        {
            try
            {
                int res = 0;

                switch (s)
                {

                    case "+": { res = x + y; break; }
                    case "-": { res = x - y; break; }
                    case "*": { res = x * y; break; }
                    case "/": { res = x / y; break; }
                    case "%": { res = x % y; break; }
                    default: {  res = 0; break; }
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpGet]
        [Route("show")]
        public void show()
        {

        }

        [HttpGet]
        [Route("showing")]
        public string showing(string id)
        {
            return id;
        }

        [HttpPost]
        [Route("Add")]
        public int Add(int x, int y)
        {
            return x + y;
        }
        [HttpPut]
        [Route("sub")]
        public int Sub(int x, int y)
        {
            return x - y;
        }

        [HttpGet]
        [Route("Mul")]
        public int Mul(int x, int y)
        {
            return x * y;
        }



    

    }
}
