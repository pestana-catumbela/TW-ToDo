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
        var todo = _context.Todo.ToList();
        return View(todo);
    }

    public IActionResult Create()
    {
        ViewData["Title"] = "Add New Task";
        return View("Form");
    }

    [HttpPost]
    public IActionResult Create(Todo todo)
    {
        _context.Todo.Add(todo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var todo = _context.Todo.Find(id);
        ViewData["Title"] = "Edit Task";
        return View("Form", todo);
    }
}