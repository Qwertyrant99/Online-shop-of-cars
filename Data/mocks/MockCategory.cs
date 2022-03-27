using SklepInternetowy.Data.Intefaces;
using SklepInternetowy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> allCategories
        {
            get
            {
                return new List<Category> {
                    new Category { categoryName = "Elektryczne samochody", desc = "Nowoczesny typ pojazdów"},
                    new Category { categoryName = "Zwykłe samochody", desc = "Auta z silnikiem spalinowym"},
                };
            }
        }
    }
}
