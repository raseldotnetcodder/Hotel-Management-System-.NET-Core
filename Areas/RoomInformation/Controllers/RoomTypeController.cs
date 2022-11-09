using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelApplication.Models;
using Microsoft.AspNetCore.Http;
using HotelApplication.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using HotelApplication.Database;

namespace HotelApplication.Areas.RoomInformation.Controllers
{
    [Area("RoomInformation")]
    public class RoomTypeController : Controller
    {
        private readonly IRoomInformation<RoomType> service;
        private readonly HotelDBContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public RoomTypeController(HotelDBContext context,
            IRoomInformation<RoomType> service,
            IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.service = service;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            RoomType data = new RoomType
            {
                RoomTypes = await service.Get()
            };
            return View(data);
        }

        public async Task<IActionResult> Save(RoomType model)
        {
            RoomType roomType = new RoomType();
            if (model.Id != 0)
            {
                roomType = await service.Details(model.Id);
            }
            roomType.RoomTypes = await service.Get();
            return View(roomType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(RoomType model, IFormFile Files)
        {
            if (ModelState.IsValid)
            {
                if(Files != null)
                {
                    string folder = "images/roomtype/";
                    folder += Guid.NewGuid().ToString() + Files.FileName;
                    string serverFolder = Path.Combine(hostingEnvironment.WebRootPath, folder);
                    model.ImageUrl = "/" + folder;
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
            var roomType = await context.RoomTypes.FindAsync(id);
            await service.Delete(roomType);
            return RedirectToAction(nameof(Index));
        }
    }
}
