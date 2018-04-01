using Conversor.Business.Services;
using UnitConverter.Business.Models;

namespace UnitConverter.Business.Services
{
    public class ConverterService : IConverterService
    {
        public Unity FromMeters(double input)
        {
            return new Unity
            {
                Feet = input * 3.2808,
                Kilometer = input / 1000,
                Inch = input * 39.370,
                Meter = input
            };
        }

        public Unity FromFeet(double input)
        {
            return new Unity
            {
                Meter = input / 3.2808,
                Kilometer = input / 3280.8,
                Inch = input * 12.000,
                Feet = input
            };
        }

        public Unity FromInches(double input)
        {
            return new Unity
            {
                Meter = input / 39.370,
                Kilometer = input / 39370,
                Feet = input * 0.083333,
                Inch = input
            };
        }

        public Unity FromKilometers(double input)
        {
            return new Unity
            {
                Meter = input / 0.0010000,
                Inch = input * 39370,
                Feet = input * 3280.8,
                Kilometer = input
            };
        }
    }
}
