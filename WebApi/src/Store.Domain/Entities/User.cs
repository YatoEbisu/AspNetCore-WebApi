using Store.Domain.Entities.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class User : EntityBase
    {
        public User(string login, string password)
        {
            Login = login;
            Password = password;
            CreatedAt = DateTime.Now;
        }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public override bool IsValid()
        {
            return Validator<User>.IsValid(this, Activator.CreateInstance<UserValidator>());
        }
    }
}
