using Store.Domain.Entities.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Order : EntityBase
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid UserId {  get; set; }
        public User User {  get; set; }
        public int Mount {  get; set; }

        public override bool IsValid()
        {
            return Validator<Order>.IsValid(this, Activator.CreateInstance<OrderValidator>());
        }
    }
}
