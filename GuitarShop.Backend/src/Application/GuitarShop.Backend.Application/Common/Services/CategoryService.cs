using Dapper;
using GuitarShop.Backend.Dal.Data;
using GuitarShop.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Backend.Application.Common.Services
{
    public class CategoryService
    {
        public IEnumerable<Category> GetAllCategory()
        {
            using( var connection = DbConnection.CreateConnection())
            {
                return connection.Query<Category>("SELECT * FROM Category");
            }
        }
        public void AddCategory(Category category)
        {
            using( var connection = DbConnection.CreateConnection())
            {
                connection.Execute("INSERT INTO Category (Name) VALUES(@Name)", category);
            }
        }
    }
}
