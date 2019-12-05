using Microsoft.AspNetCore.Mvc;
using TodoList.Entities;
using TodoList.Services;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Action, which displays a list of todo items.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var service = new TodoItemService();
            return View(service.GetAll());
        }

        /// <summary>
        /// Action, which displays todo item details.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Details(long id)
        {
            var service = new TodoItemService();
            return View(service.GetOne(id));
        }

        /// <summary>
        /// Action, which displays item addition page.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }

        /// <summary>
        /// Action, which adds an item to the list.
        /// </summary>
        /// <param name="todoItem"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddItem(TodoItem todoItem)
        {
            var service = new TodoItemService();
            service.Add(todoItem);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Action, which deletes an item from the list.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeleteItem(long id)
        {
            var service = new TodoItemService();
            service.Remove(id);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Action, which marks an item as complete.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CompleteItem(long id)
        {
            var service = new TodoItemService();
            service.Complete(id);
            return RedirectToAction("Index");
        }
    }
}
