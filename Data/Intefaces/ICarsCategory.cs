using SklepInternetowy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Data.Intefaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> allCategories { get; }
    }
}
