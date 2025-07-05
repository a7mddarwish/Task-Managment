using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskMS.Business.ServicesConstracts;

namespace TaskMS.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private ITaskService taskService { get; }

        public TaskController(ITaskService TaskService)
        {
            this.taskService = TaskService;
        }

       [HttpGet("All")]
        public async Task<IActionResult> GetAllTasks()
        {

            var tasks = taskService.GetAllTasks();

            if (tasks == null)
            {            
            return NoContent();
            }

            return Ok(tasks);

        }

    }
}
