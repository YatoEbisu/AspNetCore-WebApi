using Store.Domain.Entities;
using Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task Create(User obj)
        {
            await _userRepository.InsertAsync(obj);
        }

        public async Task<Object> Get(string login, string password)
        {
            var user = await _userRepository.FindOneAsync(x => x.Login.ToLower() == login.ToLower() && x.Password == x.Password);
            if (user == null) return null;

            var token = TokenService.GenerateToken(user);

            user.Password = "";
            return new { user = user, token = token };
        }
    }
}
