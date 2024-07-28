namespace API.Application.ViewDTOs
{
    public class LoginUserViewDTO
    {
        public LoginUserViewDTO(string email, string token)
        {
            Email = email;
            Token = token;
        }

        public string Email { get; private set; }
        public string Token { get; private set; }
    }
}
