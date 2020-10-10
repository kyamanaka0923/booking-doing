namespace booking.ExampleLib.Domain.Model.Type
{
    public class Percent
    {
        int _Percent;
        public int Value {get {return _Percent;}}

        public Percent(int value)
        {
            _Percent = value;
        }

        public int Of(int multiplier)
        {
            return (multiplier * _Percent)/100;
        }
    }
}
