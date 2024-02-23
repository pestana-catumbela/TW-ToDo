using Microsoft.AspNetCore.Mvc;

namespace TW_ToDo.Controllers;

public class TodoController : Controller
{
    public IActionResult Index() 
    {
        return View();
    }
}