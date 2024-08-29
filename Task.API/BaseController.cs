using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Task.Services.Services;

namespace Task.API
{
    public class BaseController : ControllerBase
    {
        public IActionResult ReturnFormattedResponse<T>(ServiceResponse<T> response)
        {
            if (response.Success)
            {
                return Ok(response);
            }

            return StatusCode(response.StatusCode, response.Errors);
        }
    }


}

