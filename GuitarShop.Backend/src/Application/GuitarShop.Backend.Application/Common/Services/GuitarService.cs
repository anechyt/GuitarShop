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
    public class GuitarService
    {
        public IEnumerable<Guitar> GetAllGuitars()
        {
            using(var connection = DbConnection.CreateConnection())
            {
                return connection.Query<Guitar>("SELECT * FROM Guitar");
            }
        }
        public void AddGuitar(Guitar guitar)
        {
            using (var connection = DbConnection.CreateConnection())
            {
                connection.Execute("INSERT INTO Guitar (Name, Size, NumberOfStrings, Color, Price, PhotoUrl, CategoryId) VALUES(@Name, @Size, @NumberOfStrings, @Color, @Price, @PhotoUrl, @CategoryId)", guitar);
            }
        }
    }
}
