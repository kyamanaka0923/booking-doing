
using System.Runtime.CompilerServices;

namespace booking.ExampleLib.Domain.Model.Type
{
    public class Size
    {
        int _Size;

        public int Value {get {return _Size;}}

        public Size(int size)
        {
            _Size = size;
        }

        public Size Multiply(Percent percent)
        {
            return new Size(percent.Of(_Size));
        }

        public Size Add(Size size)
        {
            return new Size(_Size + size.Value);
        }

        public Size Substract(Size size)
        {
            var result = _Size - size.Value;
            if (result < 0)
            {
                throw new System.ArgumentException();
            }
            return new Size(result);
        }

        public bool IsLarger(Size size)
        {
            return _Size > size.Value;
        }

        public static Size Of(int value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException();
            }
            return new Size(value);
        }

        public static Size Zero => Of(0);
    }
}