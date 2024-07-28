using Microsoft.AspNetCore.Identity;

namespace API.Core.Entities
{
    public class User : IdentityUser
    {
        public User(string fullName, string email, DateTime birthDate, DateTime createAt, string password, string role)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            CreateAt = createAt;
            Active = true;
            Password = password;
            Role = role;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreateAt { get; private set; }
        public bool Active { get; set; }

        public string Password { get; private set; }
        public string Role { get; private set; }

        public void Delete()
        {
            if (Active)
                Active = false;
        }
    }
}
