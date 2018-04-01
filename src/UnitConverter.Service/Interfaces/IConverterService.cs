using UnitConverter.Business.Models;

namespace Conversor.Business.Services
{
    public interface IConverterService
    {
        Unity FromMeters(double input);
        Unity FromFeet(double input);
        Unity FromInches(double input);
        Unity FromKilometers(double input);
    }
}
