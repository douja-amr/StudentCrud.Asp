using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Student_Crud_MVC.Models;
using Microsoft.EntityFrameworkCore;


namespace Student_Crud_MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _database;

        public StudentController(AppDbContext db)
        {
            _database = db;
        }

        public IActionResult Index()
        {
            var viewdt = _database.student.ToList();
            return View(viewdt);
        }
        public IActionResult Create()
        {
          
            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Create (Student st)
        {
            if (ModelState.IsValid)
            {
                _database.Add(st);
                await _database.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(st);
        }
        public async Task<ActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("Index");
            }
            var stdDetails = await _database.student.FindAsync(id);
            return View(stdDetails);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(Student stu)
        {
            if (ModelState.IsValid)
            {
                _database.Update(stu);
                await _database.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(stu);
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var stdDetails = await _database.student.FindAsync(id);
            return View(stdDetails);
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var stdDetails = await _database.student.FindAsync(id);
            return View(stdDetails);
        }

        [HttpPost]

        public async Task<ActionResult> Delete(int id)
        {

            var stdDetails = await _database.student.FindAsync(id);
            _database.student.Remove(stdDetails);
            await _database.SaveChangesAsync();

            return RedirectToAction("Index");
           
            
            
        }
    }
}
