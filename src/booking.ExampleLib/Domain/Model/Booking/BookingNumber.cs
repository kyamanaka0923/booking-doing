using System;
namespace booking.ExampleLib.Domain.Model.booking
{
    public class BookingNumber
    {
        private Guid _Number;

        public BookingNumber(Guid number)
        {
            _Number = number;
        }

        public static BookingNumber Generate()
        {
            return new BookingNumber(Guid.NewGuid());
        }
    }
}