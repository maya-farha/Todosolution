using System.Collections.Generic;
using System.Linq;
using NTierTodoApp.Models;
namespace NTierTodoApp.DataAccess
{
/// <summary>
//.مستودع البيانات إلدارة المهام باستخدام قائمة في الذاكرة 
/// </summary>
public class TaskRepository
{
private List<TaskItem> tasks = new List<TaskItem>
{
new TaskItem { Id = 1, Title = "أولى مهمة", IsComplete = false },
new TaskItem { Id = 2, Title = "ثانية مهمة", IsComplete = false }
};
public List<TaskItem> GetAll() => tasks;

public void Add(TaskItem task)
{
tasks.Add(task);
}
public TaskItem? GetById(int id)
{
return tasks.FirstOrDefault(t => t.Id == id);
}
//تنفيذ دالة حذف المهمة :TODO 
public void Delete(int id)
{
//id ابحث عن المهمة باستخدام :TODO //
//إذا كانت المهمة موجودة، قم بإزالتها من القائمة :TODO //
}
}
}
