using Microsoft.AspNetCore.Mvc;

namespace DotNetWebApiApp.Controllers
{
    [Route("api/[controller]")] // api/todo
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IActionResult TestRun()
        {
            return Ok("success");
        }
    }
}