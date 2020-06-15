using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int Date;
        public IEnumerable<CustomerSchedulePU> PUs;
      
        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public ActionResult Index()
        {

            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (_context.Employees.Where(e => e.IdentityUserId == id).SingleOrDefault() == null)
            {
                return View("Create");
            }
            else
            {

                var employee = _context.Employees.Where(e => e.IdentityUserId == id).SingleOrDefault();
                var zip = employee.ZipCode;
                var Dow = DateTime.Today.DayOfWeek.ToString();
                PUs = _context.CustomerSchedulePUs.Where(e => e.ZipCode == zip && e.DayOfWeek == Dow);
                return View(PUs);
            }
            // var applicationDbContext = _context.Employees.Include(e => e.IdentityUser);
            //return View(await applicationDbContext.ToListAsync());

            // var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //var employee = _context.Employees.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            //return View(employee);

            //if (employee == null)

            //{

            //    return RedirectToAction("Create");

            //}

            //else

            //{

            //    ViewData["CurrentFilter"] = searchDay;

            //    ViewBag.Day = searchDay;

            //    if (searchDay == "Today" || searchDay == null)

            //    {
            //        string DayOfWeek = DateTime.Today.DayOfWeek.ToString();
            //        var customers = _context.Customers.Where(c => c.ZipCode == employee.ZipCode  && c.StartDate <= DateTime.Today && c.EndDate >= DateTime.Today && c.ConfirmPickUp == false).Include(c => c.DayOfWeek).ToList();

            //        var extraDayCustomers = _context.Customers.Where(c => c.ZipCode == employee.ZipCode && c.StartDate <= DateTime.Today && c.EndDate >= DateTime.Today).Include(c => c.DayOfWeek).ToList();

            //        foreach (var person in extraDayCustomers)

            //        {

            //            if (person.ExtraPickUp.HasValue)

            //            {

            //                if (person.ExtraPickUp.Value.DayOfYear == Date)

            //                {

            //                    customers.Add(person);

            //                    person.ExtraPickUp = null;

            //                }

            //            }

            //        }

            //        return View(customers);

            //    }

            //    else

            //    {
            //        string DayOfWeek = searchDay;
            //        var filteredCustomers = _context.Customers.Where(c => c.ZipCode == employee.ZipCode ).Include(c => c.DayOfWeek).ToList();

            //        var extraDayCustomers = _context.Customers.Where(c => c.ZipCode == employee.ZipCode).Include(c => c.DayOfWeek).ToList();

            //        foreach (var person in extraDayCustomers)

            //        {

            //            if (person.ExtraPickUp.HasValue)

            //            {

            //                if (person.ExtraPickUp.Value.DayOfWeek.ToString() == searchDay)

            //                {

            //                    filteredCustomers.Add(person);

            //                    person.ExtraPickUp = null;

            //                }

            //            }

            //        }

            //        return View(filteredCustomers);

            //    }



            //}

        }
    

        public async Task<IActionResult> CustomerProfile(string item)
        {
            Customer customer = _context.Customers.Where(c => c.IdentityUserId == item).SingleOrDefault();
            return View(customer);
        }

        // GET: Employees/Details/5
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

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employees/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,Name,ZipCode,IdentityUserId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,Name,ZipCode,IdentityUserId")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
