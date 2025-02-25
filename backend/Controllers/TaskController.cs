using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Data;

namespace backend.AddControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ApiContext _context;

        public TaskController(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult CreateEdit(TaskEntry task)
        {
            if (task.Id == 0)
            {
                _context.Tasks.Add(task);
            } else 
            {
                var taskInDb = _context.Tasks.Find(task.Id);

                if (taskInDb == null)
                    return new JsonResult(NotFound());

                taskInDb = task;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(task));
        }

        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Tasks.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        
    }
}