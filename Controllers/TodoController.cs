using System.Reflection.Metadata.Ecma335;
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
        ViewData["Text"] = "Create Task";
        return View("Form");
    }

    [HttpPost]
    public IActionResult Create(Todo todo)
    {
        todo.CreatedAt = DateTime.Now;
        _context.Todo.Add(todo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var todo = _context.Todo.Find(id);
        ViewData["Title"] = "Edit Task";
        ViewData["Text"] = "Edit Task";
        return View("Form", todo);
    }

    [HttpPost]
    public IActionResult Edit(Todo todo)
    {
        _context.Todo.Update(todo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var todo = _context.Todo.Find(id);
        return View(todo);
    }

    [HttpPost]
    public IActionResult Delete(Todo todo)
    {
        _context.Todo.Remove(todo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}