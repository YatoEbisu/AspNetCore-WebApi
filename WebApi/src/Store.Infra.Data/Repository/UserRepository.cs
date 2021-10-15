using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Entities;
using Store.Domain.Interfaces;
using Store.Infra.Data.Context;

namespace Store.Infra.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly StoreContext _context;
        public UserRepository(StoreContext context) : base(context)
        {
        }

        //public User Get(string login, string password)
        //{
        //    return _context.Set<User>().Where(x => x.Login.ToLower() == login.ToLower() && x.Password == x.Password).FirstOrDefault();
        //}
    }
}
