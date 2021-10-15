using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Entities.Validator;

namespace Store.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int inventory { get; set; }

        public override bool IsValid()
        {
            return Validator<Product>.IsValid(this, Activator.CreateInstance<ProductValidator>());
        }
    }
}
