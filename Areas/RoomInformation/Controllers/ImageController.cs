using HotelApplication.Models;
using HotelApplication.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Areas.RoomInformation.Controllers
{
    [Area("RoomInformation")]
    public class ImageController : Controller
    {
        private readonly IRoomInformation<Image> service;

        public ImageController(IRoomInformation<Image> service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await service.Get();
            return View(data);
        }

        public async Task<IActionResult> GetAllImagesJson()
        {
            var images = await service.Get();
            return PartialView("GetAllImagesPartial", images);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(List<IFormFile> files)
        {
            var result = await service.AddImages(files);
            var AddedImages = new List<string>();
            foreach (var image in result.AddedImages)
            {
                AddedImages.Add(image.Name + " Added Successfully");
            }
            ViewData["AddedImages"] = AddedImages;
            ViewData["UploadErrors"] = result.UploadErrors;
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var image = await service.Details(id);
            await service.RemoveImage(image);
            return RedirectToAction(nameof(Index));
        }
    }
}
