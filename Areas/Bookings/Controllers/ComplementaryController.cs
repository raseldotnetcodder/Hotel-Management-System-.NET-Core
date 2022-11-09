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
    public class ComplementaryController : Controller
    {
        private readonly IRoomInformation<Complementary> service;
        private readonly HotelDBContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public ComplementaryController(HotelDBContext context,
            IRoomInformation<Complementary> service,
            IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.service = service;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            Complementary data = new Complementary
            {
                Complementaries = await service.Get()
            };
            return View(data);
        }

        public async Task<IActionResult> Save(Complementary model)
        {
            Complementary complementary = new Complementary();
            if (model.Id != 0)
            {
                complementary = await service.Details(model.Id);
            }
            complementary.Complementaries = await service.Get();
            return View(complementary);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Complementary model, IFormFile Files)
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
            var complementary = await context.Complementaries.FindAsync(id);
            await service.Delete(complementary);
            return RedirectToAction(nameof(Index));
        }
    }
}
