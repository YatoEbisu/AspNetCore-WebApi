using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Interfaces
{
    public interface IUserService
    {
        Task<Object> Get(string login, string password);
        Task Create(User obj);
    }
}
