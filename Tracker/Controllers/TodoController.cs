using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracker.Data.Model;
using Tracker.IRepository;

namespace Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;
        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;

        }
        //test auto deploy
        [HttpGet("")]
        public IActionResult GetTodos()
        {
            var result = _todoRepository.GetTodos();
            return Ok(result);
        }
        [HttpPost("")]
        public IActionResult AddTodo(Todo model)
        {
            var result = _todoRepository.AddTodo(model);
            return Ok(result);
        }
        [HttpDelete("")]
        public IActionResult DeleteTodo(int id)
        {
            var result = _todoRepository.DeleteTodo(id);
            return Ok(result);
        }
    }
}
