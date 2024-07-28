using API.Application.ViewDTOs;
using MediatR;

namespace API.Application.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<LoginUserViewDTO>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
