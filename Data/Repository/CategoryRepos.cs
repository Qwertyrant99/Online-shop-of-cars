using SklepInternetowy.Data.Intefaces;
using SklepInternetowy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Data.Repository
{
    public class CategoryRepos : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepos(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> allCategories => appDBContent.Category;
    }
}
