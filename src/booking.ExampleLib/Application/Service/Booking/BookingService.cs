using booking.ExampleLib.Domain.Model.booking;
using booking.ExampleLib.Domain.Model.Voyage;
using booking.ExampleLib.Domain.Model.Cargo;
namespace Booking.ExampleLib.Application.Service.BookingService
{
    public class BookingService
    {
        // 予約可能か確認する
        booking.ExampleLib.Domain.Model.booking.Booking CanBook(Voyage voyage, Cargo cargo)
        {
            return voyage.CanBook(cargo);
        }

        // 予約を記録して、予約番号を返す
        BookingNumber Booking(Voyage voyage, Cargo cargo)
        {
            return BookingNumber.Generate();
        }
    }
}