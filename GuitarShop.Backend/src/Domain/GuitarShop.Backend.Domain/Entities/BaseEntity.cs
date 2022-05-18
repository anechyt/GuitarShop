using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Backend.Domain.Entities
{
    public class BaseEntity
    {
        public Guid GID { get; set; }
        public string Name { get; set; }
    }
}
