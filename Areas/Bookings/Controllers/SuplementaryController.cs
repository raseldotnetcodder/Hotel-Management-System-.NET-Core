using HotelApplication.Data;
using HotelApplication.Models;
using HotelApplication.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Areas.Bookings.Controllers
{
    [Area("Bookings")]
    public class SuplementaryController : Controller
    {
        private readonly IRoomInformation<Suplementary> service;
        private readonly HotelDBContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public SuplementaryController(HotelDBContext context,
            IRoomInformation<Suplementary> service,
            IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.service = service;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            Suplementary data = new Suplementary
            {
                Suplementaries = await service.Get()
            };
            return View(data);
        }

        public async Task<IActionResult> Save(Suplementary model)
        {
            Suplementary suplementary = new Suplementary();
            if (model.Id != 0)
            {
                suplementary = await service.Details(model.Id);
            }
            suplementary.Suplementaries = await service.Get();
            return View(suplementary);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Suplementary model, IFormFile Files)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    await service.Post(model);
                }
                else
                {
                    await service.Edit(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Details(int id = 0)
        {
            return View(await service.Details(id));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var suplementary = await context.Suplementaries.FindAsync(id);
            await service.Delete(suplementary);
            return RedirectToAction(nameof(Index));
        }
    }
}
