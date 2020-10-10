using System;
using booking.ExampleLib.Domain.Model.Type;
namespace booking.ExampleLib.Domain.Model.Cargo
{
    public class Cargo
    {
        private Size _Size;
        public Size Size {get {return _Size;}}
        public Cargo(Size size)
        {
            _Size = size;
        }

        public bool IsLargerThan(Size other)
        {
            return _Size.IsLarger(other);
        }
    }
}