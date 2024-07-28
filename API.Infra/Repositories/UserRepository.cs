using API.Core.Entities;
using API.Core.Repositories;
using API.Infra.Persistence;
using Microsoft.AspNetCore.Identity;

namespace API.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiGatewayDBContext _apiGatewayDBContext;
        private readonly IdentityUser _identityUser;
        private readonly UserManager<User> _userManager;

        public UserRepository(ApiGatewayDBContext apiGatewayDBContext, IdentityUser identityUser, UserManager<User> userManager)
        {
            _apiGatewayDBContext = apiGatewayDBContext;
            _identityUser = identityUser;
            _userManager = userManager;
        }

        public async Task AddAsync(User user)
        {
            await _userManager.CreateAsync(user);
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash)
        {
            throw new NotImplementedException();
        }
    }
}
