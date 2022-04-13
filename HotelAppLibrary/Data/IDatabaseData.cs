using HotelAppLibrary.Models;
using System;
using System.Collections.Generic;

namespace HotelAppLibrary.Data
{
    public interface IDatabaseData
    {
        void BookGuest(string firstName,
                      string lastName,
                      string StreetAddress,
                      string City,
                      string ZipCode,
                      string State,
                      string PhoneNumber,
                      string EmailAddress,
                      DateTime startDate,
                      DateTime endDate,
                      int roomTypeId);

void CheckInGuest(int bookingId);
        List<RoomTypeModel> GetAvailableRoomTypes(DateTime startDate, DateTime endDate);
        RoomTypeModel GetRoomTypeById(int id);
        List<BookingFullModel> SearchBookings(string lastName);
    }
}