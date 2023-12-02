using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Dynamic;

namespace BlazorServerApp.Controllers
{
    /// <summary>-
    /// </summary>
    /// [ApiController]
    [Tags("Test")]
    [Route("[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class TestController : BaseController
    {
        [HttpGet]
        public IActionResult Test(string id)
        {
            try
            {
                return Ok(id);
            }
            catch (Exception ex)
            {
                return NotFound(id);
            }
            return Redirect(id);
        }
    }
}
