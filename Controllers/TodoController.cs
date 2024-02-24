using Microsoft.AspNetCore.Mvc;
using TW_ToDo.Contexts;
using TW_ToDo.Models;

namespace TW_ToDo.Controllers;

public class TodoController : Controller
{
    private readonly TWTodoContext _context;
    public TodoController(TWTodoContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var todo = _context.Todo.First();
        return View(todo);
    }
}