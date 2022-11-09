using HotelApplication.Models;
using HotelApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Services.Interface
{
    public interface IBooking<T>
    {
        List<SelectedSuplementaryViewModel> PopulateSelectedSuplementaryServices(Booking booking);
        List<SelectedComplementaryViewModel> PopulateSelectedComplementaryServices(Booking booking);
        void UpdateBookingSuplementaryList(Booking booking, int[] SelectedSuplementaryIDs);
        void UpdateBookingComplementaryList(Booking booking, int[] SelectedComplementaryIDs);
        Task<BookingSupComViewModel> GetBookingSuplementaryAndComplementary(Booking booking);
    }
}
