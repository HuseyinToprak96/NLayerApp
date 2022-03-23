using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        //Nav
        public ICollection<Product> Products { get; set; }
    }
}
