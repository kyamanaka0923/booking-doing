using Microsoft.VisualStudio.TestTools.UnitTesting;
using Booking.ExampleLib.Application.Service.BookingService;
using System;
using System.Collections.Generic;
using System.Text;
using booking.ExampleLib.Domain.Model.Voyage;
using booking.ExampleLib.Domain.Model.booking;
using booking.ExampleLib.Domain.Model.Cargo;
using booking.ExampleLib.Domain.Model.Type;

namespace Booking.ExampleLib.Application.Service.BookingService.Tests
{
    [TestClass()]
    public class BookingServiceTests
    {
        [TestMethod()]
        public void OverBooking_できる()
        {
            var initial = Voyage.Create(new Size(100), new BookingPolicy(new Percent(10)));
            var bookedCargo = new Cargo(new Size(90));
            var voyage = initial.AddCargo(bookedCargo);
            var toBookCargo = new Cargo(new Size(10));
            var bookingService = new BookingService();

            bookingService.CanBook(voyage, toBookCargo).Is(booking.ExampleLib.Domain.Model.booking.Booking.できる);
        }

        [TestMethod()]
        public void OverBooking_できない()
        {
            var initial = Voyage.Create(new Size(100), new BookingPolicy(new Percent(10)));
            var bookedCargo = new Cargo(new Size(100));
            var voyage = initial.AddCargo(bookedCargo);
            var toBookCargo = new Cargo(new Size(10));
            var bookingService = new BookingService();

            bookingService.CanBook(voyage, toBookCargo).Is(booking.ExampleLib.Domain.Model.booking.Booking.できる);
        }
    }
}