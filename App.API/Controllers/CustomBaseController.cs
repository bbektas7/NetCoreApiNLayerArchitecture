using App.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(ServiceResult<T> result)
        {
            if(result.Status == System.Net.HttpStatusCode.NoContent)
            {
                return NoContent();
            }
            if(result.Status == System.Net.HttpStatusCode.Created)
            {
                return Created(result.urlAsCreated, result);
            }
            return new ObjectResult(result) { StatusCode = (int)result.Status };
        }
        [NonAction]
        public IActionResult CreateActionResult(ServiceResult result)
        {
            if (result.Status == System.Net.HttpStatusCode.NoContent)
            {
                return new ObjectResult(null) { StatusCode = result.Status.GetHashCode() };
            }
            return new ObjectResult(result) { StatusCode = result.Status.GetHashCode() };
        }
    }
}
