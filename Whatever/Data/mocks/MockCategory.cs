using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatever.Data.interfaces;
using Whatever.Data.models;

namespace Whatever.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category {categoryName="Electrocars",description="Future is here."},
                    new Category {categoryName="Musclecars", description="Old good diesel demons. "},

                    };
            }
        }
    }
}
