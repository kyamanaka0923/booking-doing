using System;
using booking.ExampleLib.Domain.Model.Type;
using booking.ExampleLib.Domain.Model.Route;
using booking.ExampleLib.Domain.Model.booking;
using booking.ExampleLib.Domain.Model.Cargo;
namespace booking.ExampleLib.Domain.Model.Voyage
{
    public class Voyage
    {
        private Route.Route _Route;
        private Schedule _Schedule;

        private BookingPolicy _BookingPolicy;
        private Size _Capacity;
        private CargoList _CargoList;

        private Voyage(Size capacity, BookingPolicy bookingPolicy, CargoList cargoList)
        {
            _Capacity = capacity;
            _BookingPolicy = bookingPolicy;
            _CargoList = cargoList;
        }

        public Voyage AddCargo(Cargo.Cargo cargo)
        {
            var cargoList = _CargoList.AddCargo(cargo);
            return new Voyage(_Capacity, _BookingPolicy, cargoList);
        }

        public booking.Booking CanBook(Cargo.Cargo cargo)
        {
            var max = _BookingPolicy.SizeMax(_Capacity);
            var remains = max.Substract(_CargoList.Total());
            if( cargo.IsLargerThan(remains))
            {
                return booking.Booking.できない;
            }

            return booking.Booking.できる;
        }

        public static Voyage create(Size capacity, BookingPolicy bookingPolicy) => new Voyage(capacity, bookingPolicy, CargoList.Empty);
    }
}