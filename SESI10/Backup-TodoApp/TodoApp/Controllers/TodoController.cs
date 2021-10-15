using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public class TodoController:ControllerBase{
        [Route("TestRun")]
        [HttpGet]

        public ActionResult TestRun(){
            return Ok("success");
        }
    }
}