using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeesController (ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Employee
        public async Task<IActionResult> Index()
        {
            EmployeeCustomersView employeeCustomersView = new EmployeeCustomersView();
            DateTime today = DateTime.Today;
            EmployeeTrashPU employeeTrashPU = new EmployeeTrashPU();


            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            employeeCustomersView.employee = _context.Employees.Where(e => e.IdentityUserId == id).SingleOrDefault();
            

            if (_context.Employees.Where(e => e.IdentityUserId == id).SingleOrDefault() == null)
            {
                return View();
            }
            else
            {
                var employee = _context.Employees.Where(e => e.IdentityUserId == id).SingleOrDefault();
                var zip = employee.ZipCode;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(EmployeeCustomersView employeeCustomersView)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            employeeCustomersView.employee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            employeeCustomersView.DaysToChoose = new SelectList(new List<string>() { "Mon", "Tues", "Wed", "Thurs", "Fri" });
            return View(employeeCustomersView);
        }
        public ActionResult CustomerProfile(string item)
        {
            
            Customer customer = _context.Customers.Where(c => c.IdentityUserId == item ).SingleOrDefault();
            return View(customer);
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId, EmployeeName, EmployeeZipCode")]Employee employee)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert logic here
                
                
                _context.Add(employee);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
                
               
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
                return View(employee);
        } 

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Employee employee)
        {

                try
                {
                    // TODO: Add update logic here
                    _context.Update(employee);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
               

                }
                return RedirectToAction(nameof(Index));
                
        }
       

            
        public ActionResult CustomerSchdeuledPU()
        {
            return View();
        }

        // GET: Employee/Delete/5
        public async Task <IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSet(int id)
        {
            
                // TODO: Add delete logic here
                var employee = await _context.Employees.FindAsync(id);
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            
        }
    }
}