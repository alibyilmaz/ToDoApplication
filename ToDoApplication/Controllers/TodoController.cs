using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApplication.Models;
using ToDoApplication.Services;

namespace TodoApplication.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
        public async Task<IActionResult> Index()
        {
            var todoItems = await _todoItemService.GetIncompleteItemsAsync();

            // Database'den değerleri getir

            // Gelen değerleri yeni modele koy

            // Modeli Görünyüye ekle ve sayfayı göster.
            var model = new TodoViewModel()
            {
                Items = todoItems
            };
            return View(model);
        }

    }
}
