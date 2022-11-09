using HotelApplication.Data;
using HotelApplication.Models;
using HotelApplication.Services.Interface;
using HotelApplication.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Services.RoomInformation
{
    public class Bookings<T> : IBooking<T> where T : class
    {
        private readonly HotelDBContext context;
        protected DbSet<T> DbSet;
        private readonly IHostingEnvironment hostingEnvironment;

        public Bookings(HotelDBContext context,
            IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            DbSet = context.Set<T>();
            this.hostingEnvironment = hostingEnvironment;
        }

        public List<SelectedSuplementaryViewModel> PopulateSelectedSuplementaryServices(Booking booking)
        {
            var viewModel = new List<SelectedSuplementaryViewModel>();
            var allSuplementary = context.Suplementaries;
            if (booking.BookingId == 0)
            {
                foreach (var suplementary in allSuplementary)
                {
                    viewModel.Add(new SelectedSuplementaryViewModel
                    {
                        SuplementaryId = suplementary.Id,
                        Suplementary = suplementary,
                        Selected = false
                    });
                }
            }
            else
            {
                var bookingSuplementarys = context.BookingSuplementaryRelationships.Where(x => x.BookingId == booking.BookingId);
                var bookingSuplementarysIDs = new HashSet<int>(bookingSuplementarys.Select(x => x.SuplementaryId));

                foreach (var suplementary in allSuplementary)
                {
                    viewModel.Add(new SelectedSuplementaryViewModel
                    {
                        SuplementaryId = suplementary.Id,
                        Suplementary = suplementary,
                        Selected = bookingSuplementarysIDs.Contains(suplementary.Id)
                    });
                }
            }
            return viewModel;
        }

        public List<SelectedComplementaryViewModel> PopulateSelectedComplementaryServices(Booking booking)
        {
            var viewModel = new List<SelectedComplementaryViewModel>();
            var allComplementary = context.Complementaries;
            if (booking.BookingId == 0)
            {
                foreach (var complementary in allComplementary)
                {
                    viewModel.Add(new SelectedComplementaryViewModel
                    {
                        ComplementaryId = complementary.Id,
                        Complementary = complementary,
                        Selected = false
                    });
                }
            }
            else
            {
                var bookingComplementarys = context.BookingComplementaryRelationships.Where(x => x.BookingId == booking.BookingId);
                var bookingComplementarysIDs = new HashSet<int>(bookingComplementarys.Select(x => x.ComplementaryId));

                foreach (var complementary in allComplementary)
                {
                    viewModel.Add(new SelectedComplementaryViewModel
                    {
                        ComplementaryId = complementary.Id,
                        Complementary = complementary,
                        Selected = bookingComplementarysIDs.Contains(complementary.Id)
                    });
                }
            }
            return viewModel;
        }

        public void UpdateBookingSuplementaryList(Booking booking, int[] SelectedSuplementaryIDs)
        {
            var PreviouslySelectedSuplementaries = context.BookingSuplementaryRelationships.Where(x => x.BookingId == booking.BookingId);
            context.BookingSuplementaryRelationships.RemoveRange(PreviouslySelectedSuplementaries);
            context.SaveChanges();

            if (SelectedSuplementaryIDs != null)
            {
                foreach (var suplementaryID in SelectedSuplementaryIDs)
                {
                    var AllSuplementaryIDs = new HashSet<int>(context.Suplementaries.Select(x => x.Id));
                    if (AllSuplementaryIDs.Contains(suplementaryID))
                    {
                        context.BookingSuplementaryRelationships.Add(new BookingSuplementary
                        {
                            SuplementaryId = suplementaryID,
                            BookingId = booking.BookingId
                        });
                    }
                }
                context.SaveChanges();
            }
        }

        public void UpdateBookingComplementaryList(Booking booking, int[] SelectedComplementaryIDs)
        {
            var PreviouslySelectedComplementaries = context.BookingComplementaryRelationships.Where(x => x.BookingId == booking.BookingId);
            context.BookingComplementaryRelationships.RemoveRange(PreviouslySelectedComplementaries);
            context.SaveChanges();

            if (SelectedComplementaryIDs != null)
            {
                foreach (var complementaryID in SelectedComplementaryIDs)
                {
                    var AllComplementaryIDs = new HashSet<int>(context.Complementaries.Select(x => x.Id));
                    if (AllComplementaryIDs.Contains(complementaryID))
                    {
                        context.BookingComplementaryRelationships.Add(new BookingComplementary
                        {
                            ComplementaryId = complementaryID,
                            BookingId = booking.BookingId
                        });
                    }
                }
                context.SaveChanges();
            }
        }


        public async Task<BookingSupComViewModel> GetBookingSuplementaryAndComplementary(Booking booking)
        {
            var SuplementaryRelationship = context.BookingSuplementaryRelationships.Where(x => x.BookingId == booking.BookingId);
            var suplementaries = new List<Suplementary>();
            foreach (var bookingSuplementary in SuplementaryRelationship)
            {
                var suplementary = await context.Suplementaries.FindAsync(bookingSuplementary.SuplementaryId);
                suplementaries.Add(suplementary);
            }
            var ComplementaryRelationship = context.BookingComplementaryRelationships.Where(x => x.BookingId == booking.BookingId);
            var complementaries = new List<Complementary>();
            foreach (var bookingComplementary in ComplementaryRelationship)
            {
                var Complementary = await context.Complementaries.FindAsync(bookingComplementary.ComplementaryId);
                complementaries.Add(Complementary);
            }
            var ImagesAndFeatures = new BookingSupComViewModel
            {
                Suplementaries = suplementaries,
                Complementaries = complementaries
            };
            return ImagesAndFeatures;
        }

    }
}
