using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface ICountryRepository
    {
        Country GetCountry(int countryId);
        IEnumerable<Country> GetAllCountry();
    }
}
