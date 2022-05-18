using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Backend.Domain.Entities
{
    public class Guitar : BaseEntity
    {
        public float Size { get; set; }
        public int NumberOfStrings { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public Category CategoryGID { get; set; }
    }
}
