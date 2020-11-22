using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrgXDimension.Models;

namespace OrgXDimension.Controllers
{
    [Authorize]
    public class ApplicatonItemsController : Controller
    {
        private readonly OrgXDimensionContext _context;

        public ApplicatonItemsController(OrgXDimensionContext context)
        {
            _context = context;
        }

        // GET: ApplicatonItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.ApplicatonItems.ToListAsync());
        }

        // GET: ApplicatonItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicatonItems = await _context.ApplicatonItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicatonItems == null)
            {
                return NotFound();
            }

            return View(applicatonItems);
        }

        // GET: ApplicatonItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ApplicatonItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] ApplicatonItems applicatonItems)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicatonItems);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicatonItems);
        }

        // GET: ApplicatonItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicatonItems = await _context.ApplicatonItems.FindAsync(id);
            if (applicatonItems == null)
            {
                return NotFound();
            }
            return View(applicatonItems);
        }

        // POST: ApplicatonItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] ApplicatonItems applicatonItems)
        {
            if (id != applicatonItems.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicatonItems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicatonItemsExists(applicatonItems.Id))
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
            return View(applicatonItems);
        }

        // GET: ApplicatonItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicatonItems = await _context.ApplicatonItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicatonItems == null)
            {
                return NotFound();
            }

            return View(applicatonItems);
        }

        // POST: ApplicatonItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var applicatonItems = await _context.ApplicatonItems.FindAsync(id);
            _context.ApplicatonItems.Remove(applicatonItems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicatonItemsExists(int id)
        {
            return _context.ApplicatonItems.Any(e => e.Id == id);
        }
    }
}
