using HotelApplication.Data;
using HotelApplication.Models;
using HotelApplication.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Areas.RoomInformation.Controllers
{
    [Area("RoomInformation")]
    public class FeatureController : Controller
    {
        private readonly IRoomInformation<Feature> service;
        private readonly HotelDBContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public FeatureController(HotelDBContext context,
            IRoomInformation<Feature> service,
            IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.service = service;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            Feature data = new Feature
            {
                Features = await service.Get()
            };
            return View(data);
        }

        public async Task<IActionResult> Save(Feature model)
        {
            Feature feature = new Feature();
            if (model.Id != 0)
            {
                feature = await service.Details(model.Id);
            }
            return View(feature);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Feature model, IFormFile Files)
        {
            if (ModelState.IsValid)
            {
                if (Files != null)
                {
                    string folder = "images/";
                    folder += Guid.NewGuid().ToString() + Files.FileName;
                    string serverFolder = Path.Combine(hostingEnvironment.WebRootPath, folder);
                    model.Icon = "/" + folder;
                    await Files.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
                }
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
            var data = await context.Features.FindAsync(id);
            await service.Delete(data);
            return RedirectToAction(nameof(Index));
        }
    }
}
