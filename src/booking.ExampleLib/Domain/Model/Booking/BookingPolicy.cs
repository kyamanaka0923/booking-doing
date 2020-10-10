
using System;
using booking.ExampleLib.Domain.Model.Type;
namespace booking.ExampleLib.Domain.Model.booking
{
    public class BookingPolicy
    {
        Percent _Percent;

        BookingPolicy(Percent percent)
        {
            _Percent = percent;
        }

        public Size SizeMax(Size capacity)
        {
            var extend = capacity.Multiply(_Percent);
            return capacity.Add(extend);
        }

        public static BookingPolicy Of(int value)
        {
            return new BookingPolicy(new Percent(value));
        }


    }

}