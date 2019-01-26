using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {

        PersonaContext db; 
        public HomeController(PersonaContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Personas.ToListAsync()); // получаем объекты из ДБ, создаем из них список и передаем в представление
        }

               public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Persona persona)
        {
            db.Personas.Add(persona); // формируем из объекта persona sql-выражение
            await db.SaveChangesAsync(); // выполняет это ^ выражение (добавляет данные в БД)
            return RedirectToAction ("Index");
        }

        public async Task<IActionResult> Change(int? id) { // метод возвращает форму с данными объекта,
            if (id != null) {                              // котрые пользователь может отредактировать
                Persona persona = await db.Personas.FirstOrDefaultAsync(p => p.Id == id);
                if (persona != null)
                    return View(persona);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Change(Persona persona) { // метод получает изменненые данные в виде объекта
            db.Personas.Update(persona);                           // Persona и обновляет БД
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id) { // метод удаляет объект 
            if (id != null) {                              // из БД
                Persona persona = await db.Personas.FirstOrDefaultAsync(p => p.Id == id);
                if (persona != null) {
                    db.Personas.Remove(persona);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
