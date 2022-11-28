using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Interfaces
{
    public interface ICountryRepository
    {
        List<Country> GetAllCountries();
        Country GetCountry(string code);
        void DeleteCountry(string code);
        void AddCountry(Country country);
        
    }
}
