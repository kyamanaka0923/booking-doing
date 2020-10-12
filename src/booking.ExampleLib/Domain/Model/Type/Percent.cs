namespace booking.ExampleLib.Domain.Model.Type
{
    public class Percent
    {
        private readonly int _Percent;
        public int Value {get {return _Percent;}}

        public Percent(int percent)
        {
            _Percent = percent;
        }

        public int Of(int multiplier)
        {
            return (multiplier * _Percent)/100;
        }
    }
}
