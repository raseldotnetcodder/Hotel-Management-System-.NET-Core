using HotelApplication.Models;
using HotelApplication.ViewModel;
using HotelApplication.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Services.Interface
{
    public interface IRoomInformation<T>
    {
        Task<IEnumerable<T>> Get();
        Task Post(T model);
        Task Edit(T model);
        Task Delete(T model);
        Task<T> Details(int id);
        Task<IEnumerable<RoomType>> GetAllRoomTypes();
        List<SelectedRoomFeatureViewModel> PopulateSelectedFeaturesForRoom(Room room);
        void UpdateRoomFeaturesList(Room room, int[] SelectedFeatureIDs);
        Task<AddImagesViewModel> AddImages(List<IFormFile> files);
        Task RemoveImage(Image image);
        RoomsAdminIndexViewModel GetAllRoomsAndRoomTypes();
        void UpdateRoomImagesList(Room room, int[] imageIDs);
        Task<RoomFeaturesAndImagesViewModel> GetRoomFeaturesAndImages(Room room);
        Task<Booking> GetRoomDetailsByID(int id);

        Task<int> CheckRoomNo(int roomNo);
    }
}
