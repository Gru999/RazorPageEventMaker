using RazorPageEventMaker.Helpers;
using RazorPageEventMaker.Interfaces;
using RazorPageEventMaker.Models;

namespace RazorPageEventMaker.Services {
    public class JsonCountryRepository : ICountryRepository {
        string filePath = @"C:\Users\Grubak\OneDrive\Documents\Datamatiker Martriale\Code\RazorPageEventMaker\RazorPageEventMaker\JsonData\JsonCountries.json";

        public void AddCountry(Country country) {
            List<Country> countries = GetAllCountries().ToList();
            List<string> countryCodes = new List<string>();
            foreach (var cot in countries) {
                countryCodes.Add(cot.Code);
            }
            countries.Add(country);
            JsonFileWriter.WritetoJsonCountries(countries, filePath);
        }

        public void DeleteCountry(string code) {
            List<Country> countries = GetAllCountries().ToList();
            Country deleteCountry = GetCountry(code);
            countries.Remove(deleteCountry);
            JsonFileWriter.WritetoJsonCountries(countries, filePath);
        }

        public List<Country> GetAllCountries() {
            return JsonFileReader.ReadJsonCountries(filePath);
        }

        public Country GetCountry(string code) {
            List<Country> countries = GetAllCountries();
            foreach (Country cot in countries) {
                if (cot.Code.Equals(code)) {
                    return cot;
                }
            }
            return new Country();
        }
    }
}
