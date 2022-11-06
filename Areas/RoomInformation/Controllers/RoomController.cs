using HotelApplication.Data;
using HotelApplication.Models;
using HotelApplication.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Areas.RoomInformation.Controllers
{
    [Area("RoomInformation")]
    public class RoomController : Controller
    {
        private readonly IRoomInformation<Room> service;
        private readonly HotelDBContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public RoomController(HotelDBContext context,
            IRoomInformation<Room> service,
            IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.service = service;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            var data = service.GetAllRoomsAndRoomTypes();
            return View(data);
        }

        public async Task<IActionResult> Save(int id)
        {
            Room data = new Room();
            if (id != 0)
            {
                data = await service.Details(id);
            }
            ViewData["Features"] = service.PopulateSelectedFeaturesForRoom(data);
            ViewBag.RoomType = new SelectList(service.GetAllRoomTypes().Result, "Id", "RoomTypeName");
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Room model, int[] SelectedFeatureIDs, int[] imageIDs)
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
                service.UpdateRoomFeaturesList(model, SelectedFeatureIDs);
                service.UpdateRoomImagesList(model, imageIDs);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.RoomType = new SelectList(service.GetAllRoomTypes().Result, "Id", "RoomTypeName");
            return View(model);
        }

        public async Task<IActionResult> Details(int id = 0)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var data = await service.Details(id);

            if (data == null)
            {
                return NotFound();
            }
            var ImagesAndFeatures = await service.GetRoomFeaturesAndImages(data);
            ViewData["Features"] = ImagesAndFeatures.Features;
            ViewData["Images"] = ImagesAndFeatures.Images;
            return View(data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var data = await context.Rooms.FindAsync(id);
            await service.Delete(data);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CheckRoomNo(int roomNo)
        {
            var result = await service.CheckRoomNo(roomNo);
            return Json(result);
        }
    }
}
