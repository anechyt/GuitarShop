using GuitarShop.Backend.Application.Common.Services;
using GuitarShop.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Backend.Application.Common.Facade
{
    public class Facade
    {
        private readonly GuitarService _guitarService;
        private readonly CategoryService _categoryService;
        public Facade()
        {
            _categoryService = new CategoryService();
            _guitarService = new GuitarService();
        }

        public IEnumerable<Guitar> GetAllGuitars()
        {
            return _guitarService.GetAllGuitars();
        }
        public IEnumerable<Category> GetAllCategory()
        {
            return _categoryService.GetAllCategory();
        }
        public void AddGuitar(Guitar guitar)
        {
            _guitarService.AddGuitar(guitar);
        }
        public void AddCategory(Category category)
        {
            _categoryService.AddCategory(category);
        }

    }
}
