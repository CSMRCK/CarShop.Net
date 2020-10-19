using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatever.Data.interfaces;
using Whatever.Data.models;

namespace Whatever.Data.repository
{
    public class CategoryRepository : ICarsCategory
    {

        private readonly AppDbContent appDbContent;

        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
