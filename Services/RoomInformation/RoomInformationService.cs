using ByteSizeLib;
using HotelApplication.Data;
using HotelApplication.Models;
using HotelApplication.Services.Interface;
using HotelApplication.ViewModel;
using HotelApplication.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Services.RoomInformation
{
    public class RoomInformationService<T> : IRoomInformation<T> where T : class
    {
        private readonly HotelDBContext context;
        protected DbSet<T> DbSet;
        private readonly IHostingEnvironment hostingEnvironment;

        public RoomInformationService(HotelDBContext context,
            IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            DbSet = context.Set<T>();
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<IEnumerable<T>> Get()
        {
            var data = await DbSet.ToArrayAsync();
            return (data);
        }

        public async Task Post(T model)
        {
            DbSet.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task Edit(T model)
        {
            context.Update(model);
            await context.SaveChangesAsync();
        }

        public async Task Delete(T model)
        {
            DbSet.Remove(model);
            await context.SaveChangesAsync();
        }

        public async Task<T> Details(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<RoomType>> GetAllRoomTypes()
        {
            return await context.RoomTypes.ToArrayAsync();
        }

        public List<SelectedRoomFeatureViewModel> PopulateSelectedFeaturesForRoom(Room room)
        {
            var viewModel = new List<SelectedRoomFeatureViewModel>();
            var allFeatures = context.Features;
            if (room.Id == 0)
            {
                foreach (var feature in allFeatures)
                {
                    viewModel.Add(new SelectedRoomFeatureViewModel
                    {
                        FeatureId = feature.Id,
                        Feature = feature,
                        Selected = false
                    });
                }
            }
            else
            {
                var roomFeatures = context.RoomFeatureRelationships.Where(x => x.RoomId == room.Id);
                var roomFeatureIDs = new HashSet<int>(roomFeatures.Select(x => x.FeatureId));

                foreach (var feature in allFeatures)
                {
                    viewModel.Add(new SelectedRoomFeatureViewModel
                    {
                        FeatureId = feature.Id,
                        Feature = feature,
                        Selected = roomFeatureIDs.Contains(feature.Id)
                    });
                }
            }
            return viewModel;
        }

        public void UpdateRoomFeaturesList(Room room, int[] SelectedFeatureIDs)
        {
            var PreviouslySelectedFeatures = context.RoomFeatureRelationships.Where(x => x.RoomId == room.Id);
            context.RoomFeatureRelationships.RemoveRange(PreviouslySelectedFeatures);
            context.SaveChanges();

            if (SelectedFeatureIDs != null)
            {
                foreach (var featureID in SelectedFeatureIDs)
                {
                    var AllFeatureIDs = new HashSet<int>(context.Features.Select(x => x.Id));
                    if (AllFeatureIDs.Contains(featureID))
                    {
                        context.RoomFeatureRelationships.Add(new RoomFeature
                        {
                            FeatureId = featureID,
                            RoomId = room.Id
                        });
                    }
                }
                context.SaveChanges();
            }
        }

        public async Task<AddImagesViewModel> AddImages(List<IFormFile> files)
        {
            var UploadErrors = new List<string>();
            var AddedImages = new List<Image>();
            var imagesFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");

            foreach (var formFile in files)
            {
                var _ext = Path.GetExtension(formFile.FileName).ToLower();

                if (formFile.Length > 0 && formFile.Length < 1000000)
                {
                    if (!(_ext == ".jpg" || _ext == ".png" || _ext == ".gif" || _ext == ".jpeg"))
                    {
                        UploadErrors.Add("The File \"" + formFile.FileName + "\" could Not be Uploaded because it has a bad extension --> \"" + _ext + "\"");
                        continue;
                    }
                    string NewFileName;
                    var ExistingFilePath = Path.Combine(imagesFolder, formFile.FileName);
                    var FileNameWithoutExtension = Path.GetFileNameWithoutExtension(formFile.FileName);

                    for (var count = 1; File.Exists(ExistingFilePath) == true; count++)
                    {
                        FileNameWithoutExtension = FileNameWithoutExtension + " (" + count.ToString() + ")";

                        var UpdatedFileName = FileNameWithoutExtension + _ext;
                        var UpdatedFilePath = Path.Combine(imagesFolder, UpdatedFileName);
                        ExistingFilePath = UpdatedFilePath;
                    }
                    NewFileName = FileNameWithoutExtension + _ext;
                    var filePath = Path.Combine(imagesFolder, NewFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                    var image = new Image
                    {
                        Name = NewFileName,
                        Size = ByteSize.FromBytes(formFile.Length).ToString(),
                        ImageUrl = "~/images/" + NewFileName,
                        FilePath = filePath
                    };
                    AddedImages.Add(image);
                }
                else
                {
                    UploadErrors.Add(formFile.FileName + " Size is not Valid. -->(" + ByteSize.FromBytes(formFile.Length).ToString() + ")... Upload a file less than 1MB");
                }
            }
            context.Images.AddRange(AddedImages);
            context.SaveChanges();

            var result = new AddImagesViewModel
            {
                AddedImages = AddedImages,
                UploadErrors = UploadErrors
            };
            return result;
        }

        public async Task RemoveImage(Image image)
        {
            File.Delete(image.FilePath);
            context.Images.Remove(image);
            await context.SaveChangesAsync();
        }

        public RoomsAdminIndexViewModel GetAllRoomsAndRoomTypes()
        {
            var rooms = context.Rooms.ToList();
            var roomtypes = context.RoomTypes.ToList();
            var bookings = context.Bookings.ToList();

            var RoomsAdminIndeViewModel = new RoomsAdminIndexViewModel
            {
                Rooms = rooms,
                RoomTypes = roomtypes,
                BookingList = bookings
            };
            return RoomsAdminIndeViewModel;
        }

        public void UpdateRoomImagesList(Room room, int[] imageIDs)
        {
            var PreviouslySelectedImages = context.ItemImageRelationships.Where(x => x.ItemId == room.Id);
            context.ItemImageRelationships.RemoveRange(PreviouslySelectedImages);
            context.SaveChanges();

            if (imageIDs != null)
            {
                foreach (var imageID in imageIDs)
                {
                    try
                    {
                        var AllImagesIDs = new HashSet<int>(context.Images.Select(x => x.Id));
                        if (AllImagesIDs.Contains(imageID))
                        {
                            context.ItemImageRelationships.Add(new ItemImage
                            {
                                ImageId = imageID,
                                ItemId = room.Id
                            });
                        }
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                }
                context.SaveChanges();
            }
        }

        public async Task<RoomFeaturesAndImagesViewModel> GetRoomFeaturesAndImages(Room room)
        {
            var RoomImagesRelationship = context.ItemImageRelationships.Where(x => x.ItemId == room.Id);
            var images = new List<Image>();
            foreach (var RoomImage in RoomImagesRelationship)
            {
                var Image = await context.Images.FindAsync(RoomImage.ImageId);
                images.Add(Image);
            }
            var RoomFeaturesRelationship = context.RoomFeatureRelationships.Where(x => x.RoomId == room.Id);
            var features = new List<Feature>();
            foreach (var RoomFeature in RoomFeaturesRelationship)
            {
                var Feature = await context.Features.FindAsync(RoomFeature.FeatureId);
                features.Add(Feature);
            }
            var ImagesAndFeatures = new RoomFeaturesAndImagesViewModel
            {
                Images = images,
                Features = features
            };
            return ImagesAndFeatures;
        }

        public async Task<Booking> GetRoomDetailsByID(int id)
        {
            var roomDetails = await context.Rooms.FindAsync(id);
            var room = new Booking
            {
                Room = roomDetails
            };
            return room;
        }

        public async Task<int> CheckRoomNo(int roomNo)
        {
            var result = await context.Rooms.Where(x => x.RoomNumber == roomNo).Select(x => x.RoomNumber).FirstOrDefaultAsync();
            if (result != 0)
            {
                result = 2147483646;
                return result;
            }
            return result;
        }
    }
}
