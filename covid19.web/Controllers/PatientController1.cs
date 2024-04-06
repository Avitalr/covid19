using covid19.web.Data;
using covid19.web.Models;
using covid19.web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace covid19.web.Controllers
{
    public class PatientController1 : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PatientController1(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddPatiant ap)
        {
            var patient = new Patient
            {
                Id = ap.Id,
                full_Name = ap.full_Name,
                Address = ap.Address,
                Telphone = ap.Telphone,
                Mobile_Phone = ap.Mobile_Phone,
                Date_Of_Birth = ap.Date_Of_Birth,
                Covid_Positive_Date = ap.Covid_Positive_Date,
                Covid_Recovery_Date = ap.Covid_Recovery_Date
            };
            await dbContext.Patients.AddAsync(patient);
            await dbContext.SaveChangesAsync();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {

            var patients = await dbContext.Patients.ToListAsync();
            return View(patients);
        }

        

    [HttpGet]
        public async Task<IActionResult> Vaccinations(string id)
        {
            var patient = await dbContext.CoronaֹVaccine.FindAsync(id);
            return View(patient);
        }

        [HttpPost]
        public async Task<IActionResult> Vaccinations(CoronaֹVaccine cv)
        {
            var vaccin = await dbContext.CoronaֹVaccine.FindAsync(cv.Id);
            if (vaccin is not null)
            {
                vaccin.Corona_Vaccine1 = cv.Corona_Vaccine1;
                vaccin.Corona_Manufacturer1 = cv.Corona_Manufacturer1;
                vaccin.Corona_Vaccine2 = cv.Corona_Vaccine2;
                vaccin.Corona_Manufacturer2 = cv.Corona_Manufacturer2;
                vaccin.Corona_Vaccine3 = cv.Corona_Vaccine3;
                vaccin.Corona_Manufacturer3 = cv.Corona_Manufacturer3;
                vaccin.Corona_Vaccine4 = cv.Corona_Vaccine4;
                vaccin.Corona_Manufacturer4 = cv.Corona_Manufacturer4;
                 
                await dbContext.SaveChangesAsync();
            }
            else
            {
                var coronaVaccine = new CoronaֹVaccine
                {
                    Id = cv.Id,
                    Corona_Vaccine1 = cv.Corona_Vaccine1,
                    Corona_Manufacturer1 = cv.Corona_Manufacturer1,
                    Corona_Vaccine2 = cv.Corona_Vaccine2,
                    Corona_Manufacturer2 = cv.Corona_Manufacturer2,
                    Corona_Vaccine3 = cv.Corona_Vaccine3,
                    Corona_Manufacturer3 = cv.Corona_Manufacturer3,
                    Corona_Vaccine4 = cv.Corona_Vaccine4,
                    Corona_Manufacturer4 = cv.Corona_Manufacturer4
                };
                await dbContext.CoronaֹVaccine.AddAsync(coronaVaccine);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Patients");
        }
        
    }
}
