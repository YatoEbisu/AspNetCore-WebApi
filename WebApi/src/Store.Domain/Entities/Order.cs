using Store.Domain.Entities.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    [Table("Products")]
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
