using Microsoft.AspNetCore.Mvc; using Microsoft.AspNetCore.Mvc;
using NTierTodoApp.Business;
namespace NTierTodoApp.Controllers
{
public class HomeController : Controller
{
private readonly TaskService taskService;
public HomeController(TaskService service)
{
taskService = service;
}
public IActionResult Index()
{
var tasks = taskService.GetTasks();
return View(tasks);
}
[HttpPost]
public IActionResult AddTask(string title)
{
if (!string.IsNullOrWhiteSpace(title))
taskService.AddTask(title);
return RedirectToAction("Index");
}
        [HttpPost]
        public IActionResult CompleteTask(int id)
        {
            taskService.CompleteTask(id);
            return RedirectToAction("Index");
        }
//تنفيذ إجراء لحذف المهمة :TODO
[HttpPost]
public IActionResult DeleteTask(int id)
{
//TaskService استدعاء دالة حذف المهمة في :TODO
taskService.DeleteTask(id);
return RedirectToAction("Index");
}
}
}
