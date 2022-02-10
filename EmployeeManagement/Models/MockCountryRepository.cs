using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockCountryRepository : ICountryRepository
    {
        private List<Country> _countryList;

        public MockCountryRepository()
        {
            _countryList = new List<Country>() {
            new Country(){CountryName="India", CountryID= 1, CountryPopulation=1300000 },
            new Country(){CountryName="US", CountryID= 2, CountryPopulation=144555 },
            new Country(){CountryName="UK", CountryID= 3, CountryPopulation=113455 },
            };
        }

        public IEnumerable<Country> GetAllCountry()
        {
            return _countryList;
        }

        public Country GetCountry(int countryId)
        {
            return _countryList.FirstOrDefault(e => e.CountryID == countryId);
        }
    }
}
